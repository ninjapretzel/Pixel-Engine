using PixelEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEngine.Examples {
	/// <summary> Example Space Invadorks game </summary>
	public class Invaders : Game {
		/// <summary> Entrypoint </summary>
		public static void Run(string[] args) {
			Invaders game = new Invaders();
			game.Construct(400, 300, 3, 3, 60);
			game.Start();
		}
		Pixel bgColor;
		List<Entity> entities;
		Entity player;

		/// <summary> Simple entity class </summary>
		abstract class Entity {
			public Vector2 position;
			public ISprite sprite;
			public abstract void Update(Game game, float delta);
			public virtual void Draw(Game game) {
				if (sprite != null) {
					game.DrawSprite(position, sprite);
				}
			}
		}

		class Shot : Entity {
			public Vector2 speed;
			public Shot(int seed) {
				sprite = RenderShot(seed);
			}
			public override void Update(Game game, float delta) {
				position += speed;
				if (position.x < 0 - sprite.Width) { }
				if (position.y < 0 - sprite.Height) { }
				if (position.x > game.ScreenWidth) { }
				if (position.y > game.ScreenHeight) { }
			}
		}

		class Player : Entity {
			public Player(int seed) {
				sprite = RenderPlayer(seed);
			}
			public override void Update(Game game, float delta) {
				Vector2 movement = default;
				if (game.GetKey(Key.A).Down || game.GetKey(Key.Left).Down) { movement.x -= 1; }
				if (game.GetKey(Key.D).Down || game.GetKey(Key.Right).Down) { movement.x += 1; }
				if (game.GetKey(Key.W).Down || game.GetKey(Key.Up).Down) { movement.y -= 1; }
				if (game.GetKey(Key.S).Down || game.GetKey(Key.Down).Down) { movement.y += 1; }
				position += movement;
				if (position.x < 0) { position.x = 0; }
				if (position.x > game.ScreenWidth-sprite.Width) { position.x = game.ScreenWidth - sprite.Width; }
				if (position.y < game.ScreenHeight/2) { position.y = game.ScreenHeight/2; }
				if (position.y > game.ScreenHeight) { position.y = game.ScreenHeight; }
			}
		}

		class Invader : Entity {
			int speed;
			int framesPerTick;
			int framesSinceTick;
			int seed;
			ISprite[] poses;
			int frame = 0;

			public Invader(int seed, InvaderRenderSettings sets = null) {
				this.seed = seed;
				poses = RenderInvaderPoses(seed, sets);
				
				sprite = poses[0];
				speed = Randoms.RandomInt(1, 3);
				if (Randoms.RandomFloat() < .5f) {
					speed *= -1;
				}
				framesPerTick = Randoms.RandomInt(5, 10);
				framesSinceTick = 0;
				position = default;
			}
			public override void Update(Game game, float delta) {
				framesSinceTick++;
				if (framesSinceTick == framesPerTick) {
					framesSinceTick = 0;

					frame = (frame + 1) % poses.Length; 
					sprite = poses[frame];

					position.x += speed;
					if (speed > 0) {
						if (position.x >= game.ScreenWidth - sprite.Width) {
							position.x = game.ScreenWidth - sprite.Width;
							position.y += 1;
							speed *= -1;
						}
					} else {
						if (position.x <= 0) {
							position.x = 0;
							position.y += 1;
							speed *= -1;
						}
					}
					// For debug purposes.
					if (position.y >=  game.ScreenHeight / 2) {
						position.y = game.ScreenHeight /2;
					}
				}
			}
		}

		/// <inheritdoc />
		public Invaders() {
			entities = new List<Entity>();
		}
		/// <inheritdoc />
		public override void OnCreate() {
			PixelMode = Pixel.Mode.Alpha;
			Reset();
		}

		private void Reset() {
			entities.Clear();
			// Create some extra settings.
			// These end up being very colurful.
			InvaderRenderSettings vibrant = new InvaderRenderSettings();
			vibrant.minFrames = 2; vibrant.maxFrames = 5;
			vibrant.minLayers = 2; vibrant.maxLayers = 10;
			vibrant.hueChange = .3f;
			vibrant.minSatChange = 0; vibrant.maxSatChange = 1f;
			vibrant.minValChange = 0; vibrant.maxSatChange = .5f;
			vibrant.minDeco = 1; vibrant.maxDeco = 1;
			vibrant.minAnim = 1; vibrant.maxAnim = 1;

			// These are 'simple' designs with short animations
			InvaderRenderSettings simple = new InvaderRenderSettings();
			simple.minFrames = 2; simple.maxFrames = 4;
			simple.minLayers = 1; simple.maxLayers = 2;
			simple.minDeco = 1; simple.maxDeco = 2;
			simple.minAnim = 1; simple.maxAnim = 4;

			// These are default designs with long, not repeating animations.
			InvaderRenderSettings spaz = new InvaderRenderSettings(); 
			spaz.minFrames = 20; spaz.maxFrames = 40;
			
			InvaderRenderSettings vibrantSpaz = new InvaderRenderSettings(vibrant);
			vibrantSpaz.minFrames = 20; vibrantSpaz.maxFrames = 40;
			
			InvaderRenderSettings simpleSpaz = new InvaderRenderSettings(simple);
			simpleSpaz.minFrames = 20; simpleSpaz.maxFrames = 40;

			InvaderRenderSettings[] setArr = new InvaderRenderSettings[] {
				vibrant, 
				simple,
				spaz,
				simpleSpaz,
				 vibrantSpaz,
				// Default settings generate decent 'invaders' with a few decoration layers
				InvaderRenderSettings.DEFAULT
			};

			Randoms.Seed = (int)DateTime.UtcNow.Ticks;

			int numInvaders = Randoms.RandomInt(40,60);
			int[] seeds = new int[numInvaders];
			int[] whichSets = new int[numInvaders];
			int playerSeed = Randoms.RandomInt(int.MinValue, int.MaxValue);
			for (int i = 0; i < numInvaders; i++) {
				seeds[i] = Randoms.RandomInt(int.MinValue, int.MaxValue);
				whichSets[i] = Randoms.RandomInt(0, setArr.Length);
			}
			for (int i = 0; i < numInvaders; i++) {
				int seed = seeds[i];
				InvaderRenderSettings sets = setArr[whichSets[i]];

				Invader invader = new Invader(seed, sets);

				invader.position.x = Random(0, ScreenWidth);
				invader.position.y = Random(0, ScreenHeight / 2);
				entities.Add(invader);
			}

			player = new Player(playerSeed);
			player.position = new Vector2(ScreenWidth/2-7, ScreenHeight * 3 / 4);

			entities.Add(player);
		}

		/// <inheritdoc />
		public override void OnUpdate(float delta) {
			Clear(bgColor);
			if (GetKey(Key.R).Pressed) {
				Reset();
			}

			foreach (var entity in entities) {
				entity.Update(this, delta);
			}

			entities.Sort((a, b) => {
				if (a.sprite == null) { return -1; }
				if (b.sprite == null) { return 1; }
				int ay = (int)(a.position.y + a.sprite.Height);
				int by = (int)(b.position.y + b.sprite.Height);
				return ay - by;
			});
			foreach (var entity in entities) {
				entity.Draw(this);
			}
		}

		/// <summary> Quickly count the number of bits in a long. </summary>
		static int countBits(long data) {
			int cnt = 0;
			while (data != 0) {
				data = data & (data - 1);
				cnt++;
			}
			return cnt;
		}

		/// <summary> Pick up to <paramref name="numBits"/> bits from locations that are set to 1 in a <paramref name="mask"/>. </summary>
		static long PickBits(long mask, int numBits) {
			long bits = 0;
			for (int i = 0; i < numBits; i++) {
				int pos = Randoms.RandomInt(0, 63);
				long next = 1L << pos;
				// Not in requested mask, skip and retry.
				bool inMask = (next & mask) != 0;
				if (!inMask) { i--; continue; }
				// Already set that bit, skip.
				bool inBits = (next & bits) != 0;
				if (inBits) { continue; }
				bits |= next;
			}
			return bits;
		}

		/// <summary> Randomly splat bits and cut down with a <paramref name="mask"/>, and accept it when there are at least <paramref name="minBits"/> in the splat. </summary>
		static long SplatBits(long mask, int minBits) {
			long bits = 0;
			// If we ask for more bits than are in the mask, just do one iteration and return 
			if (minBits >= countBits(mask)) {
				bits |= ((long)Randoms.RandomInt(int.MinValue, int.MaxValue));
				bits |= ((long)Randoms.RandomInt(int.MinValue, int.MaxValue)) << 32;
				return bits; 
			}

			while (countBits(bits) < minBits) {
				bits = 0;
				bits |= ((long)Randoms.RandomInt(int.MinValue, int.MaxValue));
				bits |= ((long)Randoms.RandomInt(int.MinValue, int.MaxValue)) << 32;
				bits &= mask;
			}
			return bits;
		}

		/// <summary> Render invader <paramref name="bits"/> into a <see cref="PalettedSprite"/> using the given palette <paramref name="index"/></summary>
		static void RenderInvaderSprite(PalettedSprite spr, long bits, int index) {
			int w = spr.Width;
			int h = spr.Height;

			bool oddW = w % 2 == 1;
			int wbits = (oddW ? 1 : 0) + w / 2;
			for (int yy = 0; yy < h; yy++) {
				for (int xx = 0; xx < wbits; xx++) {
					int i = yy * wbits + xx;
					if (i >= 64) { Console.WriteLine("Early Return!"); return; }

					long mask = 1L << i;
					bool bit = (bits & mask) != 0;

					if (bit) {
						spr.SetIndex(xx, yy, index);
						//Mirroring
						spr.SetIndex(w - 1 - xx, yy, index);
					}

				}
			}
		}

		/// <summary> Parameterized settings for creating invader sprites. </summary>
		class InvaderRenderSettings {
			public static readonly InvaderRenderSettings DEFAULT = new InvaderRenderSettings();
			public InvaderRenderSettings() { }
			public InvaderRenderSettings(InvaderRenderSettings o) {
				minFrames = o.minFrames; maxFrames = o.maxFrames;
				minLayers = o.minLayers; maxLayers = o.maxLayers;
				minSize = o.minSize; maxSize = o.maxSize;
				hueChange = o.hueChange;
				minSatChange = o.minSatChange; maxSatChange = o.maxSatChange;
				minValChange = o.minValChange; maxValChange = o.maxValChange;
				minDeco = o.minDeco; maxDeco = o.maxDeco;
				minAnim = o.minAnim; maxAnim = o.maxAnim;
			}

			/// <summary> Control of number of pose frames to render</summary>
			public int minFrames = 2, maxFrames = 7;
			/// <summary> Get number of poses to render </summary>
			public virtual int nextFrames { get { return Randoms.RandomInt(minFrames, maxFrames+1); } }
			
			/// <summary> Control of number of layers to create. Any after 1 are considered 'decoration' layers </summary>
			public int minLayers = 2, maxLayers = 3;
			/// <summary> Get number of layers to render </summary>
			public virtual int nextLayers { get { return Randoms.RandomInt(minLayers, maxLayers+1); } }

			/// <summary> Control of sprite dimension for both width and height </summary>
			public int minSize = 4, maxSize = 10;
			/// <summary> Get a dimension </summary>
			public virtual int nextSize { get { return Randoms.RandomInt(minSize, maxSize+1); } }

			/// <summary> Control of how much 'decoration' colors may vary from base color </summary>
			public float hueChange = .2f, 
				minSatChange = -.2f, maxSatChange = .2f, 
				minValChange = -.2f, maxValChange = .2f;
			/// <summary> Get the change to 'decoration' color for one layer. </summary>
			public virtual Vector4 nextHsvChange { get {
				float h = Randoms.RandomFloat(-hueChange, hueChange);
				float s = Randoms.RandomFloat(minSatChange, maxSatChange);
				float v = Randoms.RandomFloat(minValChange, maxValChange);
				return new Vector4(h,s,v,0);
			}}

			/// <summary> Control of 'decoration' pixels per layer</summary>
			public int minDeco = 1, maxDeco = 5;
			/// <summary> Get the number of 'deco' pixels on a 'decoration' layer </summary>
			public virtual int nextDeco { get { return Randoms.RandomInt(minDeco, maxDeco+1); } }

			/// <summary> Control of 'animation' changes per layer per pose </summary>
			public int minAnim = 1, maxAnim = 5;
			/// <summary> Get the number of pixels to change on a pose </summary>
			public virtual int nextAnim { get { return Randoms.RandomInt(minAnim, maxAnim+1); } }


		}

		/// <summary> Create an invader from a <paramref name="seed"/>, rendering a set of sprites for all of its 'poses' </summary>
		static ISprite[] RenderInvaderPoses(int seed, InvaderRenderSettings sets = null) {
			if (sets == null) { sets = InvaderRenderSettings.DEFAULT; }

			Randoms.Seed = seed;
			int numFrames = sets.nextFrames;
			ISprite[] poses = new ISprite[numFrames];

			// Sprite spr = new Sprite();
			int numLayers = sets.nextLayers;
			long[] baseFrame = new long[numLayers];
			Pixel[] colors = new Pixel[numLayers + 1];

			int width = sets.nextSize;
			int height = sets.nextSize;

			int fill = (int)Mathf.Sqrt(width * height);

			int maxBits = height * width - (height * (width / 2));
			long bitMask = (1L << (1 + maxBits)) - 1L;
			Console.WriteLine($"Invader {width:D2}x{height:D2} has {maxBits:D2} bits and mask 0x{bitMask:X16}");

			Vector4 baseColor = Pixel.Random().ToHSVA();
			baseColor.w = 1.0f;
			baseFrame[0] = PickBits(bitMask, fill);
			colors[1] = Pixel.HSVA(baseColor);

			for (int i = 1; i < numLayers; i++) {
				int numDeco = sets.nextDeco;
				baseFrame[i] = PickBits(bitMask, numDeco);
				
				Vector4 colorMod = sets.nextHsvChange;

				colors[i + 1] = Pixel.HSVA(baseColor + colorMod);
			}

			for (int k = 0; k < numFrames; k++) {
				PalettedSprite spr = new PalettedSprite(width, height, colors);
				for (int i = 0; i < numLayers; i++) {
					long bits = baseFrame[i];

					if (k != 0) {
						int numFlips = sets.nextAnim;
						long mask = PickBits(bitMask, numFlips);
						bits ^= mask;
					}

					RenderInvaderSprite(spr, bits, i + 1);
				}
				poses[k] = spr;
			}
			return poses;
		}

		
		static ISprite RenderPlayer(int seed) {
			Randoms.Seed = seed;
			Pixel[] palette = new Pixel[4];
			float hue,sat,val;
			hue = Randoms.value;
			sat = .2f + .3f * Randoms.value;
			val = .2f + .3f * Randoms.value;
			Vector4 baseColor = new Vector4(hue, sat, val, 1.0f);
			palette[1] = Pixel.HSVA(baseColor);
			hue = -.1f + .2f * Randoms.value;
			sat = .3f + .2f * Randoms.value;
			val = .3f + .2f * Randoms.value;
			Vector4 cockpitColor = baseColor + new Vector4(hue,sat,val,0f);
			palette[2] = Pixel.HSVA(cockpitColor);
			hue = -.05f + .1f * Randoms.value;
			sat = -.1f - .1f * Randoms.value;
			val = -.1f - .1f * Randoms.value;
			Vector4 outlineColor = baseColor + new Vector4(hue,sat,val,0f);
			palette[3] = Pixel.HSVA(outlineColor);
			int spriteSize = 15;
			PalettedSprite spr = new PalettedSprite(spriteSize, spriteSize, palette);
			
			Vector2Int b = new Vector2Int(7,0);
			// Begin with outline
			spr.SetIndex(b.x, b.y, 3);
			// Draw Triangle
			int cockpitSize = Randoms.RandomInt(4,7);
			int invCockpitSize = (1+spriteSize) / 2 - cockpitSize;
			for (int y = 1; y < spriteSize; y++) {
				int maxOff = (y)/2;
				for (int i = 0; i <= maxOff; i++) {
					byte v = 1;
					if ( (i < spriteSize-2) && (i-1 < maxOff-invCockpitSize)) { v = 2; }
					if (i == maxOff || y == (spriteSize - 1)) { v = 3; }

					
					spr.SetIndex(b.x + i, b.y + y, v);
					spr.SetIndex(b.x - i, b.y + y, v);
				}
			}
			
			return spr;
		}


		private static Vector2 Swizzle(Vector2 v) { return new Vector2(v.y, v.x); }
		/// <summary> Render a 'shot' sprite using rotational symmetry. </summary>
		/// <param name="seed"></param>
		/// <returns></returns>
		public static ISprite RenderShot(int seed) {
			Randoms.Seed = seed;
			Pixel[] palette = new Pixel[4];
			int size = Randoms.Range(7, 20);
			
			long mask = -1;
			long bits = PickBits(mask, size + 4);
			PalettedSprite spr = new PalettedSprite(15, 15, palette);
			
			for (int i = 0; i < 64; i++) {
				if ((bits & (1 << i)) == 0) {
					continue;
				}

				Vector2Int mid = new Vector2Int(size/2, size/2);
				if (size % 2 == 1) { mid+=Vector2Int.one; }
				Vector2Int delta = new Vector2Int(i % size, i / size);

				for (int k = 0; k < 8; k++) {
					Vector2Int start = mid;
					Vector2Int step = delta;
					int quad = k / 2;
					if (size % 2 == 0) {
						if (quad == 0) {
							start.x += 1;
						} else if (quad == 1) {
						} else if (quad == 2) {
							start.y += 1;
						} else if (quad == 3) {
							start += Vector2Int.one;
						}
					}
					if (k == 0) { step.y *= -1; }


				}

			}

			return spr;
		}


	}
}
