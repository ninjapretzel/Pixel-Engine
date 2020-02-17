using PixelEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PixelEngine {
	/// <summary> Core interface for a sprite to fufill to be drawable. </summary>
	public interface ISprite {
		/// <summary> Width of sprite </summary>
		int Width { get; }
		/// <summary> Height of sprite </summary>
		int Height { get; }
		/// <summary> 2d Accessor to read <see cref="Pixel"/>s in sprite </summary>
		/// <param name="x">x coord to read at </param>
		/// <param name="y">y coord to read at </param>
		/// <returns> <see cref="Pixel"/> color at x/y </returns>
		Pixel this[int x, int y] { get; }
	}
	
	/// <summary> Class containing extension methods common for any <see cref="ISprite"/> implementation. </summary>
	public static class ISpriteExt {
		/// <summary> Gets the <see cref="ISprite.Width"/> and <see cref="ISprite.Height"/> of the given <paramref name="sprite"/> packed as a <see cref="Point"/>. </summary>
		public static Point Size(this ISprite sprite) { return new Point(sprite.Width, sprite.Height); }
	}

	/// <summary> Class holding sprite information as an array of <see cref="Pixel"/>s </summary>
	public class Sprite : ISprite {

		/// <summary> Get reference to pixel data </summary>
		/// <returns> Reference to pixel array </returns>
		public ref Pixel[] GetPixels() { return ref colorData; }
		/// <summary> Pixels in this sprite. </summary>
		private Pixel[] colorData = null;

		/// <summary> Width of sprite </summary>
		public int Width { get; private set; }
		/// <summary> Height of sprite </summary>
		public int Height { get; private set; }

		/// <summary> 2d Accessor to directly read/write <see cref="Pixel"/>s in sprite </summary>
		/// <param name="x">x coord to read/write at </param>
		/// <param name="y">y coord to read/write at </param>
		/// <returns> <see cref="Pixel"/> color at x/y </returns>
		public Pixel this[int x, int y] {
			get { return GetPixel(x, y); }
			set { SetPixel(x, y, value); }
		}
		
		/// <summary> Constructs an empty (transparent) sprite with given width/height </summary>
		/// <param name="w"> Width of sprite </param>
		/// <param name="h"> Height of sprite </param>
		public Sprite(int w, int h) {
			Width = w;
			Height = h;

			colorData = new Pixel[Width * Height];
		}

		/// <summary> Create a sprite from a <see cref="byte"/>[] and a <see cref="Pixel"/>[] palette. </summary>
		/// <param name="w"> Width of the sprite. </param>
		/// <param name="h"> Height of the sprite. </param>
		/// <param name="data"> Array of numbers representing colors to use. Each <see cref="byte"/> 
		/// represents 1 pixel worth of data, as indexed in <paramref name="palette"/>. </param>
		/// <param name="palette"> Colors to use to set up the sprite </param>
		public Sprite(int w, int h, byte[] data, Pixel[] palette) {
			Width = w;
			Height = h;
			int stop = w * h;
			if (stop != data.Length) {
				throw new Exception($"Wrong amount of data used to initialize sprite. Expected {stop} bytes, had {data.Length}.");
			}
			colorData = new Pixel[Width * Height];
			int paletteSize = palette.Length;
			for (int i = 0; i < stop; i++) {
				colorData[i] = palette[data[i] % paletteSize];
			}
		}

		/// <summary> Logic for reading <see cref="Pixel"/>s from Sprite. </summary>
		/// <param name="x"> x coord to read </param>
		/// <param name="y"> y coord to read </param>
		/// <returns> Pixel at x/y, or <see cref="Pixel.Empty"/> if x/y are invalid  </returns>
		private Pixel GetPixel(int x, int y) {
			if (x >= 0 && x < Width && y >= 0 && y < Height) { return colorData[y * Width + x]; }
			else { return Pixel.Empty; }
		}
		/// <summary> Logic for writing <see cref="Pixel"/>s from Sprite. </summary>
		/// <param name="x"> x coord to read </param>
		/// <param name="y"> y coord to read </param>
		/// <param name="p"> Pixel to write into sprite. </param>
		private void SetPixel(int x, int y, Pixel p) {
			if (x >= 0 && x < Width && y >= 0 && y < Height) { colorData[y * Width + x] = p; }
		}

		/// <summary> Load a given sprite from a BMP format file </summary>
		/// <param name="bmp"> bitmap to load from </param>
		private void LoadFromBitmap(Bitmap bmp) {
			Width = bmp.Width;
			Height = bmp.Height;

			colorData = new Pixel[Width * Height];

			unsafe {
				Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
				BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);

				byte* scan0 = (byte*)bmpData.Scan0;

				int depth = Image.GetPixelFormatSize(bmp.PixelFormat);

				int length = Width * Height * depth / 8;

				for (int x = 0; x < Width; x++) {
					for (int y = 0; y < Height; y++) {
						int i = ((y * Width) + x) * depth / 8;

						Color c = Color.Empty;

						switch (depth) {
							case 32: {
									byte b = scan0[i];
									byte g = scan0[i + 1];
									byte r = scan0[i + 2];
									byte a = scan0[i + 3];
									c = Color.FromArgb(a, r, g, b);
									break;
								}

							case 24: {
									byte b = scan0[i];
									byte g = scan0[i + 1];
									byte r = scan0[i + 2];
									c = Color.FromArgb(r, g, b);
									break;
								}

							case 8: {
									byte b = scan0[i];
									c = Color.FromArgb(b, b, b);
									break;
								}
						}

						this[x, y] = new Pixel(c.R, c.G, c.B, c.A);
					}
				}

				bmp.UnlockBits(bmpData);
			}
		}
		/// <summary> Load from an SPR file </summary>
		/// <param name="path"> Path to load from </param>
		/// <returns> Sprite loaded from SPR file </returns>
		private static Sprite LoadFromSpr(string path) {
			// Helper function to turn a single nibble into a color. 
			Pixel Parse(short col) {
				switch (col & 0xF) {
					case 0x0: return Pixel.Presets.Black;
					case 0x1: return Pixel.Presets.DarkBlue;
					case 0x2: return Pixel.Presets.DarkGreen;
					case 0x3: return Pixel.Presets.DarkCyan;
					case 0x4: return Pixel.Presets.DarkRed;
					case 0x5: return Pixel.Presets.DarkMagenta;
					case 0x6: return Pixel.Presets.DarkYellow;
					case 0x7: return Pixel.Presets.Grey;
					case 0x8: return Pixel.Presets.DarkGrey;
					case 0x9: return Pixel.Presets.Blue;
					case 0xA: return Pixel.Presets.Green;
					case 0xB: return Pixel.Presets.Cyan;
					case 0xC: return Pixel.Presets.Red;
					case 0xD: return Pixel.Presets.Magenta;
					case 0xE: return Pixel.Presets.Yellow;
					case 0xF: return Pixel.Presets.White;
				}

				return Pixel.Empty;
			}

			Sprite spr;

			using (Stream stream = File.OpenRead(path)) {
				using (BinaryReader reader = new BinaryReader(stream)) {
					int w = reader.ReadInt32();
					int h = reader.ReadInt32();

					spr = new Sprite(w, h);

					for (int i = 0; i < h; i++) {
						for (int j = 0; j < w; j++) {
							spr[j, i] = Parse(reader.ReadInt16());
						}
					}
				}
			}

			return spr;
		}

		/// <summary> Loads a sprite from a file. Currently .SPR and anything that <see cref="Image.FromFile(string)"/> can load is supported. 
		/// BMP, PNG, JPG, GIF, and TIFF Should be expected to work. YMMV on other formats. </summary>
		/// <param name="path"> Filename to load </param>
		/// <returns> Loaded sprite. </returns>
		public static Sprite Load(string path) {
			if (!File.Exists(path)) {
				return new Sprite(8, 8);
			}
			
			if (path.EndsWith(".spr")) {
				return LoadFromSpr(path);
			} else {
				using (Bitmap bmp = (Bitmap)Image.FromFile(path)) {
					Sprite spr = new Sprite(0, 0);
					spr.LoadFromBitmap(bmp);
					return spr;
				}
			}
		}
		/// <summary> Converts the given <see cref="Sprite"/> into a bitmap and saves it to a file. </summary>
		/// <param name="spr"> Sprite to save </param>
		/// <param name="path"> Path to save file to </param>
		public static void Save(Sprite spr, string path) {
			unsafe {
				using (Bitmap bmp = new Bitmap(spr.Width, spr.Height)) {
					Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
					BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, bmp.PixelFormat);

					byte* scan0 = (byte*)bmpData.Scan0;

					int depth = Image.GetPixelFormatSize(bmp.PixelFormat);

					int length = spr.Width * spr.Height * depth / 8;

					for (int x = 0; x < spr.Width; x++) {
						for (int y = 0; y < spr.Height; y++) {
							Pixel p = spr[x, y];

							int i = ((y * spr.Width) + x) * depth / 8;

							scan0[i] = p.B;
							scan0[i + 1] = p.G;
							scan0[i + 2] = p.R;
							scan0[i + 3] = p.A;
						}
					}

					bmp.UnlockBits(bmpData);

					bmp.Save(path);
				}
			}
		}
		/// <summary> Copies <see cref="Pixel"/> data from src <see cref="Sprite"/> to dest <see cref="Sprite"/> </summary>
		/// <param name="src"> Source Sprite </param>
		/// <param name="dest"> Destination Sprite </param>
		public static void Copy(Sprite src, Sprite dest) {
			if (src.colorData.Length != dest.colorData.Length) { return; }

			src.colorData.CopyTo(dest.colorData, 0);
		}


	}

	/// <summary> Class holding palatted sprite information. for 
	/// <para>Supports up to 255 colors in a Palette. </para>
	/// <para> 0 is reserved for <see cref="Pixel.Empty"/>, regardless of what it is set to internally. </para>
	/// </summary>
	public class PalettedSprite : ISprite {

		/// <summary> Information about what colors are in what positions. 0 is always transparent. </summary>
		private byte[] colors = null;
		/// <summary> Palette of <see cref="Pixel"/> colors. </summary>
		public Pixel[] palette { get; private set; } = null;


		/// <summary> Width of sprite </summary>
		public int Width { get; private set; }
		/// <summary> Height of sprite </summary>
		public int Height { get; private set; }

		/// <summary> 2d Accessor to directly read/write <see cref="Pixel"/>s in sprite </summary>
		/// <param name="x">x coord to read/write at </param>
		/// <param name="y">y coord to read/write at </param>
		/// <returns> <see cref="Pixel"/> color at x/y </returns>
		public Pixel this[int x, int y] {
			get {
				int i = x + y * Width;
				if (i < 0 || i >= colors.Length) { return new Pixel(); }
				byte b = colors[i];
				if (b == 0) { return new Pixel(); }
				return palette[b];
			}
			set {
				int i = x + y * Width;
				int ci = value.Equals(Pixel.Empty) ? 0 : Array.IndexOf(palette, value);
				if (ci < 0) { throw new InvalidOperationException($"Color (ARGB) {value.ToHexARGB()} not found in palette."); }
				colors[i] = (byte)ci;
			}
		}

		/// <summary> Gets a palette index at the given x/y coordinate </summary>
		/// <param name="x"> x coord </param>
		/// <param name="y"> y coord </param>
		/// <returns> Palette index at given coordinate </returns>
		public byte GetIndex(int x, int y) {
			int i = x + y * Width;
			if (i < 0 || i >= colors.Length) { return 0; }
			return colors[i];
		}
		/// <summary> Sets a palette index at the given x/y coordinate </summary>
		/// <param name="x"> x coord </param>
		/// <param name="y"> y coord </param>
		/// <param name="ci"> color index into Palette to set. </param>
		public void SetIndex(int x, int y, int ci) {
			int i = x + y * Width;
			if (i < 0 || i >= colors.Length) { return; }
			colors[i] = (byte)(ci&0xFF);
		}

		/// <summary> Create a new, empty <see cref="PalettedSprite"/> with the given dimensions and <see cref="Pixel"/>[] palette </summary>
		/// <param name="w"> Width of sprite </param>
		/// <param name="h"></param>
		/// <param name="palette"></param>
		public PalettedSprite(int w, int h, Pixel[] palette) {
			Width = w;
			Height = h;
			colors = new byte[w * h];
			this.palette = palette;
		}

		/// <summary> Create a copy of a given <see cref="PalettedSprite"/> with the given <paramref name="palette"/> </summary>
		/// <param name="orig"> Orignal <see cref="PalettedSprite"/> to share palette indexes with </param>
		/// <param name="palette"> <see cref="Pixel"/>[] to use as this sprite's Palette. </param>
		public PalettedSprite(PalettedSprite orig, Pixel[] palette) {
			Width = orig.Width;
			Height = orig.Height;
			colors = orig.colors;
			this.palette = palette;
		}

		/// <summary> Attempts to load a <see cref="PalettedSprite"/> from a `.pspr` format file </summary>
		/// <param name="path"> Path to file to load </param>
		/// <returns> Loaded sprite or null if load was unsuccessful. </returns>
		public static PalettedSprite LoadFromPSPR(string path) {
			PalettedSprite spr = null;

			try {
				using (Stream stream = File.OpenRead(path)) {
					using (BinaryReader reader = new BinaryReader(stream)) {
						
						if (((char)reader.ReadByte()) != 'P') { throw new InvalidDataException("Data file does not have PSPR header."); }
						if (((char)reader.ReadByte()) != 'S') { throw new InvalidDataException("Data file does not have PSPR header."); }
						if (((char)reader.ReadByte()) != 'P') { throw new InvalidDataException("Data file does not have PSPR header."); }
						if (((char)reader.ReadByte()) != 'R') { throw new InvalidDataException("Data file does not have PSPR header."); }
						
						
						int w = reader.ReadInt32();
						int h = reader.ReadInt32();
						int ncol = Mathf.Min(255, reader.ReadInt32());
						Pixel[] placeholderPalette = new Pixel[ncol+1];
						
						spr = new PalettedSprite(w,h,placeholderPalette);

						for (int y = 0; y < h; y++) {
							for (int x = 0; x < w; x++) {
								spr.SetIndex(x,y, reader.ReadByte());
							}
						}
					}
				}

			} catch (Exception e) {
				Console.WriteLine($"Error Loading PSPR {e}");
				spr = null;
			}


			return spr;
		}

		/// <summary> Attempts to save a <see cref="PalettedSprite"/> to a `.pspr` format file </summary>
		/// <param name="path"> Path to save to </param>
		public void SaveToPSPR(string path) {
			using (Stream stream = File.OpenWrite(path)) {
				using (BinaryWriter writer = new BinaryWriter(stream)) {
					writer.Write((byte)'P');
					writer.Write((byte)'S');
					writer.Write((byte)'P');
					writer.Write((byte)'R');
					writer.Write(Width);
					writer.Write(Height);
					writer.Write(Mathf.Min(255, palette.Length - 1));
					
					for (int y = 0; y < Height; y++) {
						for (int x = 0; x < Width; x++) {
							writer.Write(GetIndex(x,y));
						}
					}
				}
			}
		}

	}
}
