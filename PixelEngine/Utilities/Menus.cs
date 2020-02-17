using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEngine.Utilities {
	/// <summary> Port of OLC's PopUp Menu based on work by sms-apps. </summary>
	/// <remarks> Partially taken from https://github.com/sms-apps/OlcPixelGameEngineFun
	/// but modified further for convinience with C# features </remarks> 
	public class MenuManager {

		private static Sprite _DefaultSprite = null;
		/// <summary> Default menu skin </summary>
		public static Sprite DefaultSprite {
			get {
				if (_DefaultSprite != null) { return _DefaultSprite; }
				_DefaultSprite = new Sprite(48,24, new byte[] { // I think this is actually more compressed than the png lol.
0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,
0,0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,2,2,2,2,1,0,0,0,0,0,0,
0,0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,1,2,2,2,2,3,3,3,3,1,1,1,0,0,
0,1,2,2,2,2,3,3,3,3,3,3,3,3,3,3,3,3,2,2,2,2,1,0,0,0,0,6,6,0,0,0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,1,0,
0,1,2,2,2,3,1,1,1,1,1,1,1,1,1,1,1,1,3,2,2,2,1,0,0,0,6,6,6,6,0,0,1,2,3,2,2,2,2,2,2,2,2,2,2,2,3,1,
1,2,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,2,3,1,0,6,6,6,6,6,6,0,1,2,2,2,2,2,2,2,2,2,2,3,3,3,1,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,7,7,7,7,7,7,0,1,2,3,2,2,2,2,2,2,2,3,1,1,1,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,0,0,0,0,0,0,0,1,2,3,2,2,2,2,2,2,2,3,1,0,0,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,0,0,0,0,0,0,0,1,2,3,2,2,2,2,2,2,3,3,1,0,0,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,6,6,0,0,0,0,0,1,2,3,3,2,2,2,2,2,3,1,0,0,0,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,6,6,6,0,0,0,0,1,2,1,3,3,2,2,2,3,3,1,0,0,0,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,6,6,6,6,0,0,0,0,1,1,1,3,3,3,3,3,1,0,0,0,0,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,6,6,6,7,0,0,0,0,0,0,1,1,1,1,1,1,4,4,4,4,4,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,6,6,7,0,0,0,0,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,7,7,0,0,0,0,0,4,4,4,4,4,4,4,4,4,4,4,4,4,4,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,0,0,0,0,0,0,0,0,0,4,4,4,4,4,4,4,0,0,0,0,0,0,0,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,0,0,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,
1,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,3,1,0,6,6,6,6,6,6,0,5,5,1,1,1,1,5,5,5,5,1,1,1,1,5,5,
1,2,2,2,3,1,5,5,5,5,5,5,5,5,5,5,5,5,1,2,2,2,3,1,0,6,6,6,6,6,7,0,5,2,2,2,2,2,2,5,5,1,1,2,2,1,1,5,
0,1,2,2,2,2,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,3,1,0,0,0,6,6,6,7,0,0,5,2,2,2,2,2,2,5,5,1,2,2,2,2,1,5,
0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,1,0,0,0,0,6,6,0,0,0,5,2,2,2,2,2,2,5,5,1,2,2,2,2,1,5,
0,0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,3,3,1,0,0,0,0,0,0,0,0,0,0,5,2,2,2,2,2,2,5,5,1,1,2,2,1,1,5,
0,0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,0,0,0,0,0,0,0,0,0,0,0,5,5,2,2,2,2,5,5,5,5,2,2,2,2,5,5,
0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,
				},new Pixel[] { 
					Pixel.Empty,			// 0 Transparent
					Pixel.ARGB(0xFF4E4E4E), // 1 Dark Gray
					Pixel.ARGB(0xFFFFFFFF), // 2 White
					Pixel.ARGB(0xFFB6B6B6), // 3 Light Gray
					Pixel.ARGB(0xFF363636), // 4 Shadow Gray
					Pixel.ARGB(0xFF1427FF), // 5 Blue 
					Pixel.ARGB(0xFFFF2600), // 6 Red1
					Pixel.ARGB(0xFFA42600), // 7 Red2
					Pixel.Presets.Red,
				});

				return _DefaultSprite;
			}
		}

		/// <summary> Window pixel offset for each nested window that is opened </summary>
		public Vector2Int WindowOffset = new Vector2Int(4, 4);
		
		/// <summary> Currently open panels </summary>
		private LinkedList<MenuObject> Panels = new LinkedList<MenuObject>();

		/// <summary> Close any open menus, and show the given <see cref="MenuObject"/>. </summary>
		/// <param name="menuObject"> <see cref="MenuObject"/> to show. </param>
		public void Open(MenuObject menuObject) {
			Close();
			Panels.AddLast(menuObject);
		}
		/// <summary> Are we open? </summary>
		public bool IsOpen { get { return Panels.Count > 0; } }
		/// <summary> Closes the menu </summary>
		public void Close() { 
			Panels.Clear();
		}
		
		/// <summary> Position of the Cursor sprite object in the sprite sheet </summary>
		private static readonly Vector2Int CURSOR_PATCH = new Vector2Int(4, 0);
		/// <summary> Draws the currently open <see cref="MenuObject"/>s on the screen </summary>
		/// <param name="game"> <see cref="Game"/> to draw to </param>
		/// <param name="sheet"> <see cref="Sprite"/> to use as a sheet </param>
		/// <param name="offset"> Offset on screen </param>
		public void Draw(Game game, Sprite sheet, Vector2Int? offset) {
			if (!Panels.Any()) { return; } 
			Vector2Int screenOffset = offset ?? Vector2Int.zero;

			foreach (var panel in Panels) {
				panel.Draw(game, sheet, screenOffset);
				screenOffset += WindowOffset;
			}

			Pixel.Mode previousPixelMode = game.PixelMode;
			game.PixelMode = Pixel.Mode.Mask;
			MenuObject last = Panels.Last();
			Vector2Int patchSize = last.PatchSize;
			game.DrawPartialSprite(last.CursorPos, sheet, CURSOR_PATCH * patchSize, patchSize.x * 2, 2 * patchSize.y);
			game.PixelMode = previousPixelMode;
		}

		/// <summary> Call to send the <see cref="MenuManager"/> a 'confirmation' event. </summary>
		/// <returns> Selected <see cref="MenuObject"/>, or null if nothing was selected. </returns>
		public MenuObject OnConfirm() { 
			if (!IsOpen) { return null; }
			var next = Panels.Last().OnConfirm();
			if (next == Panels.Last()) {
				if (Panels.Last().Selected.Enabled) {
					return Panels.Last().Selected;	
				}
			} else if (next.Enabled) {
				Panels.AddLast(next);
			}
			return null;
		}
		/// <summary> Call to send the <see cref="MenuManager"/> a 'back' event. </summary>
		public void OnBack() {
			if (Panels.Any()) {
				Panels.RemoveLast();
			}
		}

		/// <summary> Call to send the <see cref="MenuManager"/> an 'up' event. </summary>
		public void OnUp() { if (Panels.Any()) { Panels.Last().OnUp(); } }
		/// <summary> Call to send the <see cref="MenuManager"/> a 'down' event. </summary>
		public void OnDown() { if (Panels.Any()) { Panels.Last().OnDown(); } }
		/// <summary> Call to send the <see cref="MenuManager"/> a 'left' event. </summary>
		public void OnLeft() { if (Panels.Any()) { Panels.Last().OnLeft(); } }
		/// <summary> Call to send the <see cref="MenuManager"/> a 'right' event. </summary>
		public void OnRight() { if (Panels.Any()) { Panels.Last().OnRight(); } }
		
	}

	/// <summary> Implementation of OLC's MenuObject </summary>
	/// <remarks> Partially taken from https://github.com/sms-apps/OlcPixelGameEngineFun
	/// but modified further for convinience with C# features </remarks> 
	public class MenuObject {

		/// <summary> Size (in game pixels) of a single menu 'patch' sprite. </summary>
		public const int DEFAULT_PATCH_SIZE = 8;

		/// <summary> Current cursor position in this <see cref="MenuObject"/> </summary>
		/// <remarks> Just a note, I would avoid using properties to wrap structs.
		/// If you use properties, you can't do 'someMenu.CellCursor.x = 5'; 
		/// since modifying a struct return value of an accessor property does not modify the one contained in the class.
		/// If there's no access difference between get/set, I would just keep it as a plain field. </remarks>
		protected Vector2Int Cursor = new Vector2Int(0, 0);

		/// <summary> Number of empty cells between each entry in this <see cref="MenuObject"/> </summary>
		protected Vector2Int Padding = new Vector2Int(2, 0);

		/// <summary> Size in cells of this <see cref="MenuObject"/> </summary>
		protected Vector2Int Size;

		/// <summary> Size of the 'table' for this <see cref="MenuObject"/> </summary>
		protected Vector2Int Table;

		/// <summary> Current index of the cursor in this <see cref="MenuObject"/> </summary>
		protected int CursorIndex = 0;

		/// <summary> Current cursor position of this <see cref="MenuObject"/> </summary>
		public Vector2Int CursorPos = new Vector2Int(0, 0);

		/// <summary> Is this <see cref="MenuObject"/> enabled? </summary>
		public bool Enabled = true;

		/// <summary> ID of this <see cref="MenuObject"/> </summary>
		public int Id = -1;

		/// <summary> Content from string to ID </summary>
		protected Dictionary<string, int> Indexes = new Dictionary<string, int>();

		/// <summary> Ordered list of elements in this Submenu </summary>
		protected List<MenuObject> Items = new List<MenuObject>();

		/// <summary> Name of this <see cref="MenuObject"/> </summary>
		public string Name;

		/// <summary> Size of a single 'patch' tile in this <see cref="MenuObject"/>. </summary>
		public Vector2Int PatchSize = new Vector2Int(DEFAULT_PATCH_SIZE, DEFAULT_PATCH_SIZE);

		/// <summary> Calculated size of this <see cref="MenuObject"/> in patch tiles. </summary>
		protected Vector2Int SizeInPatches = new Vector2Int(0, 0);

		/// <summary> Index of the current top visible row in this <see cref="MenuObject"/> </summary>
		public int TopVisibleRow { get; protected set; }

		/// <summary> Total number of rows in this <see cref="MenuObject"/> </summary>
		public int TotalRows { get; protected set; }

		/// <summary> Currently selected item </summary>
		public MenuObject Selected { get { return Items[CursorIndex]; } }

		/// <summary> Size of this <see cref="MenuObject"/> </summary>
		public Vector2Int MeasuredSize { get { return new Vector2Int(Name.Length, 1); } }

		/// <summary> Does this <see cref="MenuObject"/> have any children? </summary>
		public bool HasChildren { get { return Items.Count > 0; } }


		/// <summary> Allow access down into <see cref="MenuObject"/> as an indexer. </summary>
		/// <param name="key"> Name of <see cref="MenuObject"/> to get. </param>
		/// <returns> Submenu with the given name, creating it if it did not exist before. </returns>
		public MenuObject this[string key] {
			get {
				if (!Indexes.ContainsKey(key)) {
					Indexes[key] = Items.Count;
					Items.Add(new MenuObject(key));
				}
				return Items[Indexes[key]];
			}
		}

		/// <summary> Empty constructor, makes the root <see cref="MenuObject"/> </summary>
		public MenuObject() : this("root") { }
		/// <summary> Makes a Submenu with the given <paramref name="name"/>. </summary>
		/// <param name="name"> Name of this <see cref="MenuObject"/></param>
		public MenuObject(string name) {
			Name = name;
		}

		/// <summary> Sets the <see cref="Table"/> field of this <see cref="MenuObject"/> 
		/// and returns the <see cref="MenuObject"/> it was called on </summary>
		/// <param name="cols"> Number of columns in the table </param>
		/// <param name="rows"> Number of rows in the table </param>
		/// <returns> Same <see cref="MenuObject"/> that the method was called on. </returns>
		public MenuObject SetTable(int cols, int rows) { Table = new Vector2Int(cols, rows); return this; }

		/// <summary> Sets the <see cref="Id"/> field of this <see cref="MenuObject"/> 
		/// and returns the same <see cref="MenuObject"/> it was called on </summary>
		/// <param name="id"> ID to set </param>
		/// <returns> Same <see cref="MenuObject"/> that the method was called on.</returns>
		public MenuObject SetId(int id) { Id = id; return this; }

		/// <summary> Sets the <see cref="Enabled"/> field of this <see cref="MenuObject"/>
		/// and returns the same <see cref="MenuObject"/> it was called on </summary>
		/// <param name="b"> Should the option be enabled? </param>
		/// <returns> Same <see cref="MenuObject"/> that the method was called on. </returns>
		public MenuObject Enable(bool b) { Enabled = b; return this; }

		/// <summary> Build this <see cref="MenuObject"/> and all children. </summary>
		public void Build() {
			foreach (MenuObject item in Items) {
				if (item.HasChildren) { item.Build(); }
				Size = Vector2Int.Max(item.MeasuredSize, Size);
			}
			Vector2Int one = Vector2Int.one;
			SizeInPatches = Table * Size + (Table - one) * Padding + (2 * one);
			TotalRows = Items.Count / Table.x + (Items.Count % Table.x > 0 ? 1 : 0);
		}

		/// <summary> Called to send a 'confirm' signal. </summary>
		/// <returns> Selected Submenu to enter </returns>
		public MenuObject OnConfirm() {
			var it = Items[CursorIndex];
			if (it.HasChildren) { return it; }
			return this;
		}

		/// <summary> Location in sprite sheet for the 'up scroll hint' </summary>
		private static readonly Vector2Int UP_SCROLL_PATCH = new Vector2Int(3, 0);
		/// <summary> Location in sprite sheet for the 'down scroll hint' </summary>
		private static readonly Vector2Int DOWN_SCROLL_PATCH = new Vector2Int(3, 2);
		/// <summary> Location in sprite sheet for the 'another menu hint' </summary>
		private static readonly Vector2Int EXPAND_PATCH = new Vector2Int(3, 1);
		/// <summary> Draws only this panel on the game's screen. </summary>
		/// <param name="game"> <see cref="Game"/> to draw to </param>
		/// <param name="sheet"> <see cref="Sprite"/> sheet to draw with </param>
		/// <param name="offset"> Optional offset on screen </param>
		public void Draw(Game game, Sprite sheet, Vector2Int? offset = null) {
			Vector2Int screenOffset = offset ?? Vector2Int.zero;
			Vector2Int one = Vector2Int.one;

			Pixel.Mode previousPixelMode = game.PixelMode;
			game.PixelMode = Pixel.Mode.Mask;

			// Draw panel and border
			for (Vector2Int pp = Vector2Int.zero; pp.y < SizeInPatches.y; pp.y++) {
				for (pp.x = 0; pp.x < SizeInPatches.x; pp.x++) {
					Vector2Int screenLocation = pp * PatchSize + screenOffset;
					Vector2Int sourcePatch = Vector2Int.zero;

					if (pp.x > 0) { sourcePatch.x = (pp.x == SizeInPatches.x - 1) ? 2 : 1; }
					if (pp.y > 0) { sourcePatch.y = (pp.y == SizeInPatches.y - 1) ? 2 : 1; }

					game.DrawPartialSprite(screenLocation, sheet, sourcePatch * PatchSize, PatchSize.x, PatchSize.y);
				}
			}

			int topLeft = TopVisibleRow * Table.x;
			int bottomRight = Math.Min(Table.y * Table.x + topLeft, Items.Count);

			int visibleItems = bottomRight - topLeft;
			if (TopVisibleRow > 0) {
				Vector2Int screenLocation = new Vector2Int(SizeInPatches.x - 2, 0) * PatchSize + screenOffset;
				game.DrawPartialSprite(screenLocation, sheet, UP_SCROLL_PATCH * PatchSize, PatchSize.x, PatchSize.y);
			}
			if ((TotalRows - TopVisibleRow) > Table.y) {
				Vector2Int screenLocation = new Vector2Int(SizeInPatches.x - 2, SizeInPatches.y - 1) * PatchSize + screenOffset;
				game.DrawPartialSprite(screenLocation, sheet, DOWN_SCROLL_PATCH * PatchSize, PatchSize.x, PatchSize.y);
			}

			for (int i = 0; i < visibleItems; i++) {
				Vector2Int cell = new Vector2Int(i % Table.x, i / Table.x);
				Vector2Int patchPosition = cell * (Size + Padding) + one;
				Vector2Int screenLocation = patchPosition * PatchSize + screenOffset;

				var item = Items[topLeft + i];
				game.DrawText(screenLocation, item.Name, item.Enabled ? Pixel.Presets.White : Pixel.Presets.DarkGrey);

				if (item.HasChildren) {
					patchPosition = cell * (Size + Padding) + one;
					patchPosition.x += Size.x;
					screenLocation = patchPosition * PatchSize + screenOffset;
					game.DrawPartialSprite(screenLocation, sheet, EXPAND_PATCH * PatchSize, PatchSize.x, PatchSize.y);
				}
			}

			CursorPos = new Vector2Int(Cursor.x, Cursor.y - TopVisibleRow) * (Size + Padding) * PatchSize + screenOffset;
			CursorPos.x -= PatchSize.x;
			CursorPos.y += PatchSize.x;


			game.PixelMode = previousPixelMode;
		}

		/// <summary> Called to send an 'up' signal. </summary>
		public void OnUp() {
			Cursor.y--;
			MaybeRowUp();
			ClampCursor();
		}


		/// <summary> Called to send a 'down' signal. </summary>
		public void OnDown() {
			Cursor.y++;
			MaybeRowDown();
			ClampCursor();
		}

		/// <summary> Called to send a 'left' signal. </summary>
		public void OnLeft() {
			Cursor.x--;
			MaybeRowUp();
			ClampCursor();
		}
		/// <summary> Called to send a 'right' signal. </summary>
		public void OnRight() {
			Cursor.x++;
			MaybeRowDown();
			ClampCursor();
		}

		private void MaybeRowUp() {
			if (Cursor.x < 0) { Cursor.y--; Cursor.x = Table.x - 1; }
			if (Cursor.y < TopVisibleRow) {
				TopVisibleRow = Mathf.Clamp(--TopVisibleRow, 0, TotalRows - Table.y);
			}
		}

		private void MaybeRowDown() {
			if (Cursor.x > Table.x - 1) { Cursor.y++; Cursor.x = 0; }
			if (Cursor.y > (TopVisibleRow + Table.y - 1)) {
				TopVisibleRow = Mathf.Clamp(++TopVisibleRow, 0, TotalRows - Table.y);
			}
		}

		/// <summary> Prevent cursor index from going out of the menu </summary>
		public void ClampCursor() {

			CursorIndex = Cursor.y * Table.x + Cursor.x;
			if (CursorIndex >= Items.Count) {
				CursorIndex = Items.Count - 1;
				Cursor.x = CursorIndex % Table.x;
				Cursor.y = CursorIndex / Table.x;
			}
			if (CursorIndex < 0) {
				Cursor = Vector2Int.zero;
				CursorIndex = 0;
			}
		}

	}
}
