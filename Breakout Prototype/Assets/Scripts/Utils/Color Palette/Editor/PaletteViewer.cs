using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using JustKrated.Utils;

namespace JustKrated
{

	public class PaletteViewer : EditorWindow
	{
		/// <summary> Minimum Window width </summary>
		private const float WINDOW_MIN_WIDTH = 200f;
		/// <summary> Minimum Window height </summary>
		private const float WINDOW_MIN_HEIGHT = 600f;

		Vector2 scrollPos_Manage;

		[MenuItem ("Tools/Colors Viewer", false, 0)]
		public static void GetWindow ()
		{
			PaletteViewer editor = GetWindow<PaletteViewer> ("Palette", true);
			editor.minSize = new Vector2 (WINDOW_MIN_WIDTH, WINDOW_MIN_HEIGHT);
		}

		void Awake ()
		{

		}

		private void OnGUI ()
		{
			ShowMainWindow ();
		}

		private void ShowMainWindow ()
		{
			EditorGUILayout.BeginVertical ("Box");

			scrollPos_Manage = EditorGUILayout.BeginScrollView (scrollPos_Manage, false, false, GUILayout.ExpandWidth (true), GUILayout.Height (0));

			DisplayAllColors ();

			EditorGUILayout.EndScrollView ();

			EditorGUILayout.EndVertical ();
		}

		private void DisplayAllColors ()
		{
			// WHITE
			DisplayLabel ("White");
			DisplayColor (nameof (ColorPalette.White), ColorPalette.White);
			DisplayColor (nameof (ColorPalette.Snow), ColorPalette.Snow);
			DisplayColor (nameof (ColorPalette.HoneyDew), ColorPalette.HoneyDew);
			DisplayColor (nameof (ColorPalette.MintCream), ColorPalette.MintCream);
			DisplayColor (nameof (ColorPalette.Azure), ColorPalette.Azure);
			DisplayColor (nameof (ColorPalette.AliceBlue), ColorPalette.AliceBlue);
			DisplayColor (nameof (ColorPalette.GhostWhite), ColorPalette.GhostWhite);
			DisplayColor (nameof (ColorPalette.WhiteSmoke), ColorPalette.WhiteSmoke);
			DisplayColor (nameof (ColorPalette.SeaShell), ColorPalette.SeaShell);
			DisplayColor (nameof (ColorPalette.Beige), ColorPalette.Beige);
			DisplayColor (nameof (ColorPalette.OldLace), ColorPalette.OldLace);
			DisplayColor (nameof (ColorPalette.FloralWhite), ColorPalette.FloralWhite);
			DisplayColor (nameof (ColorPalette.Ivory), ColorPalette.Ivory);
			DisplayColor (nameof (ColorPalette.AntiqueWhite), ColorPalette.AntiqueWhite);
			DisplayColor (nameof (ColorPalette.Linen), ColorPalette.Linen);
			DisplayColor (nameof (ColorPalette.LavenderBlush), ColorPalette.LavenderBlush);
			DisplayColor (nameof (ColorPalette.MistyRose), ColorPalette.MistyRose);

			// GRAY
			DisplayLabel ("Gray");
			DisplayColor (nameof (ColorPalette.Gainsboro), ColorPalette.Gainsboro);
			DisplayColor (nameof (ColorPalette.LightGrey), ColorPalette.LightGrey);
			DisplayColor (nameof (ColorPalette.Silver), ColorPalette.Silver);
			DisplayColor (nameof (ColorPalette.Gray), ColorPalette.Gray);
			DisplayColor (nameof (ColorPalette.DarkGrey), ColorPalette.DarkGrey);
			DisplayColor (nameof (ColorPalette.DimGrey), ColorPalette.DimGrey);
			DisplayColor (nameof (ColorPalette.BlackGrey), ColorPalette.BlackGrey);
			DisplayColor (nameof (ColorPalette.LightSlateGray), ColorPalette.LightSlateGray);
			DisplayColor (nameof (ColorPalette.DarkSlateGray), ColorPalette.DarkSlateGray);
			DisplayColor (nameof (ColorPalette.Black), ColorPalette.Black);

			// RED
			DisplayLabel ("Red");
			DisplayColor (nameof (ColorPalette.IndianRed), ColorPalette.IndianRed);
			DisplayColor (nameof (ColorPalette.LightCoral), ColorPalette.LightCoral);
			DisplayColor (nameof (ColorPalette.Salmon), ColorPalette.Salmon);
			DisplayColor (nameof (ColorPalette.DarkSalmon), ColorPalette.DarkSalmon);
			DisplayColor (nameof (ColorPalette.LightSalmon), ColorPalette.LightSalmon);
			DisplayColor (nameof (ColorPalette.Crimson), ColorPalette.Crimson);
			DisplayColor (nameof (ColorPalette.Red), ColorPalette.Red);
			DisplayColor (nameof (ColorPalette.FireBrick), ColorPalette.FireBrick);
			DisplayColor (nameof (ColorPalette.DarkRed), ColorPalette.DarkRed);
			DisplayColor (nameof (ColorPalette.Auburn), ColorPalette.Auburn);
			DisplayColor (nameof (ColorPalette.Blood), ColorPalette.Blood);
			DisplayColor (nameof (ColorPalette.Burgundy), ColorPalette.Burgundy);
			DisplayColor (nameof (ColorPalette.Carmine), ColorPalette.Carmine);
			DisplayColor (nameof (ColorPalette.Carnelian), ColorPalette.Carnelian);

			// YELLOW/ORANGE
			DisplayLabel ("Yellow / Orange");
			DisplayColor (nameof (ColorPalette.Coral), ColorPalette.Coral);
			DisplayColor (nameof (ColorPalette.Tomato), ColorPalette.Tomato);
			DisplayColor (nameof (ColorPalette.OrangeRed), ColorPalette.OrangeRed);
			DisplayColor (nameof (ColorPalette.DarkOrangeRed), ColorPalette.DarkOrangeRed);
			DisplayColor (nameof (ColorPalette.DarkOrange), ColorPalette.DarkOrange);
			DisplayColor (nameof (ColorPalette.Orange), ColorPalette.Orange);
			DisplayColor (nameof (ColorPalette.Flame), ColorPalette.Flame);
			DisplayColor (nameof (ColorPalette.Cinnabar), ColorPalette.Cinnabar);
			DisplayColor (nameof (ColorPalette.Gold), ColorPalette.Gold);
			DisplayColor (nameof (ColorPalette.DarkYellow), ColorPalette.DarkYellow);
			DisplayColor (nameof (ColorPalette.Yellow), ColorPalette.Yellow);
			DisplayColor (nameof (ColorPalette.LightYellow), ColorPalette.LightYellow);

			// PINK
			DisplayLabel ("Pink");
			DisplayColor (nameof (ColorPalette.Pink), ColorPalette.Pink);
			DisplayColor (nameof (ColorPalette.LightPink), ColorPalette.LightPink);
			DisplayColor (nameof (ColorPalette.HotPink), ColorPalette.HotPink);
			DisplayColor (nameof (ColorPalette.DeepPink), ColorPalette.DeepPink);
			DisplayColor (nameof (ColorPalette.FuchsiaPink), ColorPalette.FuchsiaPink);
			DisplayColor (nameof (ColorPalette.MediumVioletRed), ColorPalette.MediumVioletRed);
			DisplayColor (nameof (ColorPalette.PaleVioletRed), ColorPalette.PaleVioletRed);

			// PURPLE
			DisplayLabel ("Purple");
			DisplayColor (nameof (ColorPalette.Lavender), ColorPalette.Lavender);
			DisplayColor (nameof (ColorPalette.Thistle), ColorPalette.Thistle);
			DisplayColor (nameof (ColorPalette.Plum), ColorPalette.Plum);
			DisplayColor (nameof (ColorPalette.Violet), ColorPalette.Violet);
			DisplayColor (nameof (ColorPalette.Orchid), ColorPalette.Orchid);
			DisplayColor (nameof (ColorPalette.Fuchsia), ColorPalette.Fuchsia);
			DisplayColor (nameof (ColorPalette.Magenta), ColorPalette.Magenta);
			DisplayColor (nameof (ColorPalette.MediumOrchid), ColorPalette.MediumOrchid);
			DisplayColor (nameof (ColorPalette.MediumPurple), ColorPalette.MediumPurple);
			DisplayColor (nameof (ColorPalette.RebeccaPurple), ColorPalette.RebeccaPurple);
			DisplayColor (nameof (ColorPalette.BlueViolet), ColorPalette.BlueViolet);
			DisplayColor (nameof (ColorPalette.DarkViolet), ColorPalette.DarkViolet);
			DisplayColor (nameof (ColorPalette.DarkMagenta), ColorPalette.DarkMagenta);
			DisplayColor (nameof (ColorPalette.Purple), ColorPalette.Purple);
			DisplayColor (nameof (ColorPalette.Indigo), ColorPalette.Indigo);
			DisplayColor (nameof (ColorPalette.DarkSlateBlue), ColorPalette.DarkSlateBlue);
			DisplayColor (nameof (ColorPalette.MediumSlateBlue), ColorPalette.MediumSlateBlue);
			DisplayColor (nameof (ColorPalette.SlateBlue), ColorPalette.SlateBlue);

			// BLUE
			DisplayLabel ("Blue");
			DisplayColor (nameof (ColorPalette.CadetBlue), ColorPalette.CadetBlue);
			DisplayColor (nameof (ColorPalette.SteelBlue), ColorPalette.SteelBlue);
			DisplayColor (nameof (ColorPalette.LightSteelBlue), ColorPalette.LightSteelBlue);
			DisplayColor (nameof (ColorPalette.PowderBlue), ColorPalette.PowderBlue);
			DisplayColor (nameof (ColorPalette.LightBlue), ColorPalette.LightBlue);
			DisplayColor (nameof (ColorPalette.SkyBlue), ColorPalette.SkyBlue);
			DisplayColor (nameof (ColorPalette.DeepSkyBlue), ColorPalette.DeepSkyBlue);
			DisplayColor (nameof (ColorPalette.DodgerBlue), ColorPalette.DodgerBlue);
			DisplayColor (nameof (ColorPalette.CornflowerBlue), ColorPalette.CornflowerBlue);
			DisplayColor (nameof (ColorPalette.RoyalBlue), ColorPalette.RoyalBlue);
			DisplayColor (nameof (ColorPalette.Denim), ColorPalette.Denim);
			DisplayColor (nameof (ColorPalette.Blue), ColorPalette.Blue);
			DisplayColor (nameof (ColorPalette.MediumBlue), ColorPalette.MediumBlue);
			DisplayColor (nameof (ColorPalette.DarkBlue), ColorPalette.DarkBlue);
			DisplayColor (nameof (ColorPalette.Navy), ColorPalette.Navy);
			DisplayColor (nameof (ColorPalette.MidnightBlue), ColorPalette.MidnightBlue);

			// CYAN
			DisplayLabel ("Cyan / Teal");
			DisplayColor (nameof (ColorPalette.IceBlue), ColorPalette.IceBlue);
			DisplayColor (nameof (ColorPalette.Aqua), ColorPalette.Aqua);
			DisplayColor (nameof (ColorPalette.Cyan), ColorPalette.Cyan);
			DisplayColor (nameof (ColorPalette.MediumAqua), ColorPalette.MediumAqua);
			DisplayColor (nameof (ColorPalette.LightCyan), ColorPalette.LightCyan);
			DisplayColor (nameof (ColorPalette.Paleturqouise), ColorPalette.Paleturqouise);
			DisplayColor (nameof (ColorPalette.Aquamarine), ColorPalette.Aquamarine);
			DisplayColor (nameof (ColorPalette.MediumTurquoise), ColorPalette.MediumTurquoise);
			DisplayColor (nameof (ColorPalette.DarkTurquoise), ColorPalette.DarkTurquoise);
			DisplayColor (nameof (ColorPalette.LightSeaGreen), ColorPalette.LightSeaGreen);
			DisplayColor (nameof (ColorPalette.DarkCyan), ColorPalette.DarkCyan);
			DisplayColor (nameof (ColorPalette.Teal), ColorPalette.Teal);
			DisplayColor (nameof (ColorPalette.MediumAquamarine), ColorPalette.MediumAquamarine);
			DisplayColor (nameof (ColorPalette.DarkAquamarine), ColorPalette.DarkAquamarine);

			// GREEN
			DisplayLabel ("Green");
			DisplayColor (nameof (ColorPalette.GreenYellow), ColorPalette.GreenYellow);
			DisplayColor (nameof (ColorPalette.ChartReuse), ColorPalette.ChartReuse);
			DisplayColor (nameof (ColorPalette.LawnGreen), ColorPalette.LawnGreen);
			DisplayColor (nameof (ColorPalette.Lime), ColorPalette.Lime);
			DisplayColor (nameof (ColorPalette.LimeGreen), ColorPalette.LimeGreen);
			DisplayColor (nameof (ColorPalette.PaleGreen), ColorPalette.PaleGreen);
			DisplayColor (nameof (ColorPalette.LightGreen), ColorPalette.LightGreen);
			DisplayColor (nameof (ColorPalette.MediumSpringGreen), ColorPalette.MediumSpringGreen);
			DisplayColor (nameof (ColorPalette.SpringGreen), ColorPalette.SpringGreen);
			DisplayColor (nameof (ColorPalette.MediumSeaGreen), ColorPalette.MediumSeaGreen);
			DisplayColor (nameof (ColorPalette.SeaGreen), ColorPalette.SeaGreen);
			DisplayColor (nameof (ColorPalette.DarkSeaGreen), ColorPalette.DarkSeaGreen);
			DisplayColor (nameof (ColorPalette.ForestGreen), ColorPalette.ForestGreen);
			DisplayColor (nameof (ColorPalette.Green), ColorPalette.Green);
			DisplayColor (nameof (ColorPalette.DarkGreen), ColorPalette.DarkGreen);
			DisplayColor (nameof (ColorPalette.YellowGreen), ColorPalette.YellowGreen);
			DisplayColor (nameof (ColorPalette.OliveDrab), ColorPalette.OliveDrab);
			DisplayColor (nameof (ColorPalette.Olive), ColorPalette.Olive);
			DisplayColor (nameof (ColorPalette.DarkOliveGreen), ColorPalette.DarkOliveGreen);

			// BROWN
			DisplayLabel ("Brown");
			DisplayColor (nameof (ColorPalette.SandyBrown), ColorPalette.SandyBrown);
			DisplayColor (nameof (ColorPalette.GoldenRod), ColorPalette.GoldenRod);
			DisplayColor (nameof (ColorPalette.DarkGoldenRod), ColorPalette.DarkGoldenRod);
			DisplayColor (nameof (ColorPalette.Peru), ColorPalette.Peru);
			DisplayColor (nameof (ColorPalette.Chocolate), ColorPalette.Chocolate);
			DisplayColor (nameof (ColorPalette.SaddleBrown), ColorPalette.SaddleBrown);
			DisplayColor (nameof (ColorPalette.Sienna), ColorPalette.Sienna);
			DisplayColor (nameof (ColorPalette.Brown), ColorPalette.Brown);
			DisplayColor (nameof (ColorPalette.Maroon), ColorPalette.Maroon);

			// NEON
			DisplayLabel ("Neon");
			DisplayColor (nameof (ColorPalette.NeonWhite), ColorPalette.NeonWhite);
			DisplayColor (nameof (ColorPalette.NeonCyan), ColorPalette.NeonCyan);
			DisplayColor (nameof (ColorPalette.NeonBlue), ColorPalette.NeonBlue);
			DisplayColor (nameof (ColorPalette.NeonGreen), ColorPalette.NeonGreen);
			DisplayColor (nameof (ColorPalette.NeonYellow), ColorPalette.NeonYellow);
			DisplayColor (nameof (ColorPalette.NeonOrange), ColorPalette.NeonOrange);
			DisplayColor (nameof (ColorPalette.NeonRed), ColorPalette.NeonRed);
			DisplayColor (nameof (ColorPalette.NeonPink), ColorPalette.NeonPink);
			DisplayColor (nameof (ColorPalette.NeonViolet), ColorPalette.NeonViolet);

			// LIGHTS
			DisplayLabel ("Lux");
			DisplayColor (nameof (ColorPalette.LuxCyan), ColorPalette.LuxCyan);
			DisplayColor (nameof (ColorPalette.LuxBlue), ColorPalette.LuxBlue);
			DisplayColor (nameof (ColorPalette.LuxGreen), ColorPalette.LuxGreen);
			DisplayColor (nameof (ColorPalette.LuxYellow), ColorPalette.LuxYellow);
			DisplayColor (nameof (ColorPalette.LuxOrange), ColorPalette.LuxOrange);
			DisplayColor (nameof (ColorPalette.LuxRed), ColorPalette.LuxRed);
			DisplayColor (nameof (ColorPalette.LuxPink), ColorPalette.LuxPink);
			DisplayColor (nameof (ColorPalette.LuxViolet), ColorPalette.LuxViolet);
			DisplayColor (nameof (ColorPalette.LuxGold), ColorPalette.LuxGold);
		}

		private void DisplayLabel (string label)
		{
			GUILayout.Space (5);
			EditorGUILayout.LabelField (label);
		}

		private void DisplayColor (string title, Color color)
		{
			EditorGUILayout.BeginHorizontal ("Box");

			EditorGUILayout.ColorField (title, color);

			EditorGUILayout.EndHorizontal ();

			GUILayout.Space (1);
		}


	}

}