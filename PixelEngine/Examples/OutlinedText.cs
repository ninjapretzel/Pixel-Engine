using PixelEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEngine.Examples {
	/// <summary> Example showing usage of outlined text </summary>
	public class OutlinedText : Game{ 
		/// <summary> Entry point </summary>
		/// <param name="args"></param>
		public static void Run(string[] args) {
			OutlinedText game = new OutlinedText();
			game.Construct(400, 400, 2, 2, 60);
			game.Start();
		}

		int textScale = 1;
		/// <inheritdoc />
		public override void OnUpdate(float delta) {
			float time = Clock.Elapsed;
			// Change colors of stuff over time 
			Pixel clearColor = Pixel.HSVA(time * .277f, .5f + .5f * Mathf.Sin(time * .523f), .5f + .5f * Mathf.Sin(time * .516f));
			Clear(clearColor);
			
			Pixel textColor = Pixel.HSVA(time * .405f, .8f + .2f * Mathf.Sin(time * .734f), .8f + .2f * Mathf.Sin(time * .703f));
			Pixel textColor2 = Pixel.HSVA(time * .405f, .8f + .2f * Mathf.Sin(time * .734f), .8f + .2f * Mathf.Sin(time * .703f), .5f + .5f * Mathf.Sin(time * 1.25f));
			Pixel outlineColor = Pixel.Presets.Black;
			Pixel outlineColor2 = Pixel.HSVA(0,0,0, .75f + .25f * Mathf.Sin(time * 1.5f));
			
			if (GetKey(Key.K1).Pressed) { textScale = 1; }
			if (GetKey(Key.K2).Pressed) { textScale = 2; }
			if (GetKey(Key.K3).Pressed) { textScale = 3; }
			if (GetKey(Key.K4).Pressed) { textScale = 4; }

			Vector2 offset = (new Vector2(Mathf.Cos(time * 1.311f), Mathf.Sin(time * 1.311f)) * ScreenWidth/5.0f);
			Point p = (new Vector2(ScreenWidth/2, ScreenHeight/2));
			string text =	  "  This text is  " +
							"\n   (probably)   " +
							"\nalways readable.";
			Point size = Font.Measure(text) * textScale;

			p -= size/2;

			DrawTextOutline(p + offset, text, textColor, outlineColor, textScale);
			DrawTextOutline(p - offset, text, textColor2, outlineColor2, textScale);

			DrawTextOutline(Point.Origin + new Point(5,5), "Press 1-4 to change text scale", textColor, outlineColor, textScale);
		}

	}
}
