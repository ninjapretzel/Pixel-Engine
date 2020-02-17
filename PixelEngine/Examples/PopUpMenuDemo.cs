using PixelEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEngine.Examples {
	
	public class PopUpMenuDemo : Game {
		
		/// <summary> Entry point, formerly Main. </summary>
		public static void Run(string[] args) {
			PopUpMenuDemo game = new PopUpMenuDemo();
			game.Construct(480, 240, 2, 2);
			game.Start();
		}

		/// <summary> Menu Manager to use to navigate the menu </summary>
		public MenuManager menu; 
		/// <summary> Menu object holding information about where things are </summary>
		public MenuObject root;
		/// <summary> Demo selection. </summary>
		public string lastAction = "Nothing Selected";

		/// <inheritdoc />
		public override void OnCreate() {
			menu = new MenuManager();

			root = new MenuObject().SetTable(1,4);
			root["Attack"].SetId(1000);
			root["Magic"].SetTable(1,2);
			root["Defend"].SetId(1002);
			root["Items"].SetTable(2,4);
			root["Escape"].SetId(1003);
			
			int whiteMag = 4001;
			root["Magic"]["White"].SetTable(3,6);
			root["Magic"]["White"]["Cure"].SetId(whiteMag++);
			root["Magic"]["White"]["Cura"].SetId(whiteMag++);
			root["Magic"]["White"]["Curaga"].SetId(whiteMag++);
			root["Magic"]["White"]["Life"].SetId(whiteMag++);
			root["Magic"]["White"]["Holy"].SetId(whiteMag++);
			root["Magic"]["White"]["Ultima"].SetId(whiteMag++);
			root["Magic"]["White"]["Esuna"].SetId(whiteMag++);
			root["Magic"]["White"]["Basuna"].SetId(whiteMag++);
			root["Magic"]["White"]["Haste"].SetId(whiteMag++);
			root["Magic"]["White"]["Slow"].SetId(whiteMag++);
			root["Magic"]["White"]["Blink"].SetId(whiteMag++);
			root["Magic"]["White"]["Mini"].SetId(whiteMag++);
			root["Magic"]["White"]["Shell"].SetId(whiteMag++);
			root["Magic"]["White"]["Wall"].SetId(whiteMag++);
			root["Magic"]["White"]["Sap"].SetId(whiteMag++);
			root["Magic"]["White"]["Fog"].SetId(whiteMag++);
			root["Magic"]["White"]["Fear"].SetId(whiteMag++);
			root["Magic"]["White"]["Warp"].SetId(whiteMag++);

			int blackMag = 5001;
			root["Magic"]["Black"].SetTable(3,4);
			root["Magic"]["Black"]["Fire"].SetId(blackMag++);
			root["Magic"]["Black"]["Fira"].SetId(blackMag++);
			root["Magic"]["Black"]["Firaga"].SetId(blackMag++);
			root["Magic"]["Black"]["Thunder"].SetId(blackMag++);
			root["Magic"]["Black"]["Thundara"].SetId(blackMag++);
			root["Magic"]["Black"]["Thundaga"].SetId(blackMag++);
			root["Magic"]["Black"]["Blizzard"].SetId(blackMag++);
			root["Magic"]["Black"]["Blizzara"].SetId(blackMag++);
			root["Magic"]["Black"]["Blizzaga"].SetId(blackMag++);
			root["Magic"]["Black"]["Quake"].SetId(blackMag++);
			root["Magic"]["Black"]["Quake2"].SetId(blackMag++);
			root["Magic"]["Black"]["Quake3"].SetId(blackMag++);
			root["Magic"]["Black"]["HalfLife"].SetId(blackMag++);
			root["Magic"]["Black"]["HalfLife2"].SetId(blackMag++);
			root["Magic"]["Black"]["HalfLife3"].SetId(blackMag++).Enable(false);
			root["Magic"]["Black"]["Bio"].SetId(blackMag++);
			root["Magic"]["Black"]["Bio2"].SetId(blackMag++);
			root["Magic"]["Black"]["Bio3"].SetId(blackMag++);
			root["Magic"]["Black"]["Demi"].SetId(blackMag++);
			root["Magic"]["Black"]["Demi2"].SetId(blackMag++);
			root["Magic"]["Black"]["Demi23"].SetId(blackMag++);
			root["Magic"]["Black"]["Drain"].SetId(blackMag++);
			root["Magic"]["Black"]["Osmose"].SetId(blackMag++);
			root["Magic"]["Black"]["Sleep"].SetId(blackMag++);
			root["Magic"]["Black"]["Stun"].SetId(blackMag++);
			root["Magic"]["Black"]["Stop"].SetId(blackMag++);
			root["Magic"]["Black"]["Confuse"].SetId(blackMag++);
			root["Magic"]["Black"]["Blind"].SetId(blackMag++);
			root["Magic"]["Black"]["Curse"].SetId(blackMag++);
			root["Magic"]["Black"]["Toad"].SetId(blackMag++);
			root["Magic"]["Black"]["Break"].SetId(blackMag++);
			root["Magic"]["Black"]["Death"].SetId(blackMag++);
			root["Magic"]["Black"]["Berserk"].SetId(blackMag++);
			root["Magic"]["Black"]["Aura"].SetId(blackMag++);
			root["Magic"]["Black"]["Flare"].SetId(blackMag++);

			int itemId = 3001;
			root["Items"]["Potion"].SetId(itemId++);
			root["Items"]["Ether"].SetId(itemId++);
			root["Items"]["Elixir"].SetId(itemId++);
			root["Items"]["SleepBag"].SetId(itemId++).Enable(false);
			root["Items"]["Tent"].SetId(itemId++).Enable(false);
			root["Items"]["Cottage"].SetId(itemId++).Enable(false);

			root.Build();
			menu.Open(root);
		}

		/// <inheritdoc />
		public override void OnUpdate(float delta) {
			MenuObject command = null;

			if (GetKey(Key.Up).Pressed) { menu.OnUp(); }
			if (GetKey(Key.Down).Pressed) { menu.OnDown(); }
			if (GetKey(Key.Left).Pressed) { menu.OnLeft(); }
			if (GetKey(Key.Right).Pressed) { menu.OnRight(); }

			if (GetKey(Key.Z).Pressed) { menu.OnBack(); }
			if (GetKey(Key.X).Pressed) { command = menu.OnConfirm(); }
			if (GetKey(Key.C).Pressed) {
				if (menu.IsOpen) { menu.Close(); } else { menu.Open(root); }
			}

			if (command != null) {
				lastAction = $"Selected: {command.Name} ID: {command.Id}";
				menu.Close();
			}


			Clear(Pixel.Presets.Black);
			menu.Draw(this, MenuManager.DefaultSprite, new Vector2Int(30,30));
			DrawText(new Vector2Int(10, 200), lastAction, Pixel.Presets.White);
			
		}
	}

}
