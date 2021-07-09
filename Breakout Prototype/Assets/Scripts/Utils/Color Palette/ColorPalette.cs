using UnityEngine;

namespace JustKrated.Utils
{

	public static class ColorPalette
	{
		#region * GRAY COLORS*

		private static Color gainsboro = GetColor ("#DCDCDC");
		private static Color lightGray = GetColor ("#D3D3D3");
		private static Color silver = GetColor ("#C0C0C0");
		private static Color darkGray = GetColor ("#808080");
		private static Color gray = GetColor ("#A9A9A9");
		private static Color dimGray = GetColor ("#696969");
		private static Color blackGray = GetColor ("#323232");
		private static Color lightSlateGray = GetColor ("#778899");
		private static Color slateGray = GetColor ("#708090");
		private static Color darkSlateGray = GetColor ("#2F4F4F");
		private static Color black = Color.black;

		public static Color Gainsboro { get => gainsboro; }
		public static Color LightGrey { get => lightGray; }
		public static Color Silver { get => silver; }
		public static Color DarkGrey { get => darkGray; }
		public static Color Gray { get => gray; }
		public static Color DimGrey { get => dimGray; }
		public static Color BlackGrey { get => blackGray; }
		public static Color LightSlateGray { get => lightSlateGray; }
		public static Color SlateGray { get => slateGray; }
		public static Color DarkSlateGray { get => darkSlateGray; }
		public static Color Black { get => black; }

		#endregion

		#region * WHITE COLORS *

		private static Color white = Color.white;
		private static Color snow = GetColor ("#FFFAFA");
		private static Color honeyDew = GetColor ("#F0FFF0");
		private static Color mintCream = GetColor ("#F5FFFA");
		private static Color azure = GetColor ("#F0FFFF");
		private static Color aliceBlue = GetColor ("#F0F8FF");
		private static Color ghostWhite = GetColor ("#F8F8FF");
		private static Color whiteSmoke = GetColor ("#F5F5F5");
		private static Color seaShell = GetColor ("#FFF5EE");
		private static Color beige = GetColor ("#F5F5DC");
		private static Color oldLace = GetColor ("#FDF5E6");
		private static Color floralWhite = GetColor ("#FFFAF0");
		private static Color ivory = GetColor ("#FFFFF0");
		private static Color antiqueWhite = GetColor ("#FAEBD7");
		private static Color linen = GetColor ("#FAF0E6");
		private static Color lavenderBlush = GetColor ("#FFF0F5");
		private static Color mistyRose = GetColor ("#FFE4E1");

		public static Color White { get => white; }
		public static Color Snow { get => snow; }
		public static Color HoneyDew { get => honeyDew; }
		public static Color MintCream { get => mintCream; }
		public static Color Azure { get => azure; }
		public static Color AliceBlue { get => aliceBlue; }
		public static Color GhostWhite { get => ghostWhite; }
		public static Color WhiteSmoke { get => whiteSmoke; }
		public static Color SeaShell { get => seaShell; }
		public static Color Beige { get => beige; }
		public static Color OldLace { get => oldLace; }
		public static Color FloralWhite { get => floralWhite; }
		public static Color Ivory { get => ivory; }
		public static Color AntiqueWhite { get => antiqueWhite; }
		public static Color Linen { get => linen; }
		public static Color LavenderBlush { get => lavenderBlush; }
		public static Color MistyRose { get => mistyRose; }

		#endregion

		#region * RED COLORS *

		private static Color indianRed = GetColor ("#CD5C5C");
		private static Color lightCoral = GetColor ("#F08080");
		private static Color salmon = GetColor ("#FA8072");
		private static Color darkSalmon = GetColor ("#E9967A");
		private static Color lightSalmon = GetColor ("#FFA07A");
		private static Color crimson = GetColor ("#DC143C");
		private static Color red = GetColor ("#FF0000");
		private static Color fireBrick = GetColor ("#B22222");
		private static Color darkRed = GetColor ("#8B0000");
		private static Color auburn = GetColor ("#A52A2A");
		private static Color blood = GetColor ("#660000");
		private static Color burgundy = GetColor ("#800020");
		private static Color carmine = GetColor ("#960018");
		private static Color carnelian = GetColor ("#B31B1B");

		public static Color IndianRed { get => indianRed; }
		public static Color LightCoral { get => lightCoral; }
		public static Color Salmon { get => salmon; }
		public static Color DarkSalmon { get => darkSalmon; }
		public static Color LightSalmon { get => lightSalmon; }
		public static Color Crimson { get => crimson; }
		public static Color Red { get => red; }
		public static Color FireBrick { get => fireBrick; }
		public static Color DarkRed { get => darkRed; }
		public static Color Auburn { get => auburn; }
		public static Color Blood { get => blood; }
		public static Color Burgundy { get => burgundy; }
		public static Color Carmine { get => carmine; }
		public static Color Carnelian { get => carnelian; }

		#endregion

		#region * YELLOW/ORANGE COLORS *

		private static Color coral = GetColor ("#FF7F50");
		private static Color tomato = GetColor ("#FF6347");
		private static Color orangeRed = GetColor ("#FF4500");
		private static Color darkOrangeRed = GetColor ("#EC6900");
		private static Color darkOrange = GetColor ("#FF8C00");
		private static Color orange = GetColor ("#FFA500");
		private static Color flame = GetColor ("#E25822");
		private static Color cinnabar = GetColor ("#E44D2E");
		private static Color gold = GetColor ("#FFD700");
		private static Color darkYellow = GetColor ("#989A00");
		private static Color yellow = GetColor ("#FFFF00");
		private static Color lightYellow = GetColor ("#FFFFE0");

		public static Color Coral { get => coral; }
		public static Color Tomato { get => tomato; }
		public static Color OrangeRed { get => orangeRed; }
		public static Color DarkOrangeRed { get => darkOrangeRed; }
		public static Color DarkOrange { get => darkOrange; }
		public static Color Orange { get => orange; }
		public static Color Flame { get => flame; }
		public static Color Cinnabar { get => cinnabar; }
		public static Color Gold { get => gold; }
		public static Color DarkYellow { get => darkYellow; }
		public static Color Yellow { get => yellow; }
		public static Color LightYellow { get => lightYellow; }

		#endregion

		#region * PINK COLORS *

		private static Color pink = GetColor ("#FFC0CB");
		private static Color lightPink = GetColor ("#FFB6C1");
		private static Color hotPink = GetColor ("#FF69B4");
		private static Color deepPink = GetColor ("#FF1493");
		private static Color fuchsiaPink = GetColor ("#FF77FF");
		private static Color mediumVioletRed = GetColor ("#C71585");
		private static Color paleVioletRed = GetColor ("#DB7093");

		public static Color Pink { get => pink; }
		public static Color LightPink { get => lightPink; }
		public static Color HotPink { get => hotPink; }
		public static Color DeepPink { get => deepPink; }
		public static Color FuchsiaPink { get => fuchsiaPink; }
		public static Color MediumVioletRed { get => mediumVioletRed; }
		public static Color PaleVioletRed { get => paleVioletRed; }

		#endregion

		#region * PURPLE COLORS *

		private static Color lavender = GetColor ("#E6E6FA");
		private static Color thistle = GetColor ("#D8BFD8");
		private static Color plum = GetColor ("#DDA0DD");
		private static Color violet = GetColor ("#EE82EE");
		private static Color orchid = GetColor ("#DA70D6");
		private static Color fuchsia = GetColor ("#FF00FF");
		private static Color magenta = GetColor ("#FF0090");
		private static Color mediumOrchid = GetColor ("#BA55D3");
		private static Color mediumPurple = GetColor ("#9370DB");
		private static Color rebeccaPurple = GetColor ("#663399");
		private static Color blueViolet = GetColor ("#8A2BE2");
		private static Color darkViolet = GetColor ("#9400D3");
		private static Color darkOrchid = GetColor ("#9932CC");
		private static Color darkMagenta = GetColor ("#8B008B");
		private static Color purple = GetColor ("#800080");
		private static Color indigo = GetColor ("#4B0082");
		private static Color darkSlateBlue = GetColor ("#483D8B");
		private static Color mediumSlateBlue = GetColor ("#7B68EE");
		private static Color slateBlue = GetColor ("#6A5ACD");

		public static Color Lavender { get => lavender; }
		public static Color Thistle { get => thistle; }
		public static Color Plum { get => plum; }
		public static Color Violet { get => violet; }
		public static Color Orchid { get => orchid; }
		public static Color Fuchsia { get => fuchsia; }
		public static Color Magenta { get => magenta; }
		public static Color MediumOrchid { get => mediumOrchid; }
		public static Color MediumPurple { get => mediumPurple; }
		public static Color RebeccaPurple { get => rebeccaPurple; }
		public static Color BlueViolet { get => blueViolet; }
		public static Color DarkViolet { get => darkViolet; }
		public static Color DarkOrchid { get => darkOrchid; }
		public static Color DarkMagenta { get => darkMagenta; }
		public static Color Purple { get => purple; }
		public static Color Indigo { get => indigo; }
		public static Color DarkSlateBlue { get => darkSlateBlue; }
		public static Color MediumSlateBlue { get => mediumSlateBlue; }
		public static Color SlateBlue { get => slateBlue; }

		#endregion

		#region * BLUE COLORS *

		private static Color cadetBlue = GetColor ("#5F9EA0");
		private static Color steelBlue = GetColor ("#4682B4");
		private static Color lightSteelBlue = GetColor ("#B0C4DE");
		private static Color powderBlue = GetColor ("#B0E0E6");
		private static Color lightBlue = GetColor ("#ADD8E6");
		private static Color skyBlue = GetColor ("#87CEEB");
		private static Color lightSkyBlue = GetColor ("#87CEFA");
		private static Color deepSkyBlue = GetColor ("#00BFFF");
		private static Color dodgerBlue = GetColor ("#1E90FF");
		private static Color cornflowerBlue = GetColor ("#6495ED");
		private static Color royalBlue = GetColor ("#4169E1");
		private static Color denim = GetColor ("#1560bd");
		private static Color blue = GetColor ("#0000FF");
		private static Color mediumBlue = GetColor ("#0000CD");
		private static Color darkBlue = GetColor ("#00008B");
		private static Color navy = GetColor ("#000080");
		private static Color midnightBlue = GetColor ("#191970");

		public static Color CadetBlue { get => cadetBlue; }
		public static Color SteelBlue { get => steelBlue; }
		public static Color LightSteelBlue { get => lightSteelBlue; }
		public static Color PowderBlue { get => powderBlue; }
		public static Color LightBlue { get => lightBlue; }
		public static Color SkyBlue { get => skyBlue; }
		public static Color LightSkyBlue { get => lightSkyBlue; }
		public static Color DeepSkyBlue { get => deepSkyBlue; }
		public static Color DodgerBlue { get => dodgerBlue; }
		public static Color CornflowerBlue { get => cornflowerBlue; }
		public static Color RoyalBlue { get => royalBlue; }
		public static Color Denim { get => denim; }
		public static Color Blue { get => blue; }
		public static Color MediumBlue { get => mediumBlue; }
		public static Color DarkBlue { get => darkBlue; }
		public static Color Navy { get => navy; }
		public static Color MidnightBlue { get => midnightBlue; }

		#endregion

		#region * CYAN/TEAL COLORS *

		private static Color iceBlue = GetColor ("#99FFFF");
		private static Color aqua = GetColor ("#86ABA5");
		private static Color cyan = GetColor ("#00FFFF");
		private static Color mediumAqua = GetColor ("#47F3D0");
		private static Color lightCyan = GetColor ("#E0FFFF");
		private static Color paleturqouise = GetColor ("#AFEEEE");
		private static Color aquamarine = GetColor ("#7FFFD4");
		private static Color turquoise = GetColor ("#40E0D0");
		private static Color mediumTurquoise = GetColor ("#48D1CC");
		private static Color darkTurquoise = GetColor ("#00CED1");
		private static Color lightSeaGreen = GetColor ("#20B2AA");
		private static Color darkCyan = GetColor ("#008B8B");
		private static Color teal = GetColor ("#008080");
		private static Color mediumAquamarine = GetColor ("#66CDAA");
		private static Color darkAquamarine = GetColor ("#006760");

		public static Color IceBlue { get => iceBlue; }
		public static Color Aqua { get => aqua; }
		public static Color Cyan { get => cyan; }
		public static Color MediumAqua { get => mediumAqua; }
		public static Color LightCyan { get => lightCyan; }
		public static Color Paleturqouise { get => paleturqouise; }
		public static Color Aquamarine { get => aquamarine; }
		public static Color Turquoise { get => turquoise; }
		public static Color MediumTurquoise { get => mediumTurquoise; }
		public static Color DarkTurquoise { get => darkTurquoise; }
		public static Color LightSeaGreen { get => lightSeaGreen; }
		public static Color DarkCyan { get => darkCyan; }
		public static Color Teal { get => teal; }
		public static Color MediumAquamarine { get => mediumAquamarine; }
		public static Color DarkAquamarine { get => darkAquamarine; }

		#endregion

		#region * GREEN COLORS *

		private static Color greenYellow = GetColor ("#ADFF2F");
		private static Color chartReuse = GetColor ("#7FFF00");
		private static Color lawnGreen = GetColor ("#7CFC00");
		private static Color lime = GetColor ("#00FF00");
		private static Color limeGreen = GetColor ("#32CD32");
		private static Color paleGreen = GetColor ("#98FB98");
		private static Color lightGreen = GetColor ("#90EE90");
		private static Color mediumSpringGreen = GetColor ("#00FA9A");
		private static Color springGreen = GetColor ("#00FF7F");
		private static Color mediumSeaGreen = GetColor ("#3CB371");
		private static Color seaGreen = GetColor ("#2E8B57");
		private static Color darkSeaGreen = GetColor ("#8FBC8B");
		private static Color forestGreen = GetColor ("#228B22");
		private static Color green = GetColor ("#008000");
		private static Color darkGreen = GetColor ("#006400");
		private static Color yellowGreen = GetColor ("#9ACD32");
		private static Color oliveDrab = GetColor ("#6B8E23");
		private static Color olive = GetColor ("#808000");
		private static Color darkOliveGreen = GetColor ("#556B2F");

		public static Color GreenYellow { get => greenYellow; }
		public static Color ChartReuse { get => chartReuse; }
		public static Color LawnGreen { get => lawnGreen; }
		public static Color Lime { get => lime; }
		public static Color LimeGreen { get => limeGreen; }
		public static Color PaleGreen { get => paleGreen; }
		public static Color LightGreen { get => lightGreen; }
		public static Color MediumSpringGreen { get => mediumSpringGreen; }
		public static Color SpringGreen { get => springGreen; }
		public static Color MediumSeaGreen { get => mediumSeaGreen; }
		public static Color SeaGreen { get => seaGreen; }
		public static Color DarkSeaGreen { get => darkSeaGreen; }
		public static Color ForestGreen { get => forestGreen; }
		public static Color Green { get => green; }
		public static Color DarkGreen { get => darkGreen; }
		public static Color YellowGreen { get => yellowGreen; }
		public static Color OliveDrab { get => oliveDrab; }
		public static Color Olive { get => olive; }
		public static Color DarkOliveGreen { get => darkOliveGreen; }

		#endregion

		#region * BROWN COLORS * 

		private static Color sandyBrown = GetColor ("#F4A460");
		private static Color goldenRod = GetColor ("#DAA520");
		private static Color darkGoldenRod = GetColor ("#B8860B");
		private static Color peru = GetColor ("#CD853F");
		private static Color chocolate = GetColor ("#D2691E");
		private static Color saddleBrown = GetColor ("#8B4513");
		private static Color sienna = GetColor ("#A0522D");
		private static Color brown = GetColor ("#A52A2A");
		private static Color maroon = GetColor ("#800000");

		public static Color SandyBrown { get => sandyBrown; }
		public static Color GoldenRod { get => goldenRod; }
		public static Color DarkGoldenRod { get => darkGoldenRod; }
		public static Color Peru { get => peru; }
		public static Color Chocolate { get => chocolate; }
		public static Color SaddleBrown { get => saddleBrown; }
		public static Color Sienna { get => sienna; }
		public static Color Brown { get => brown; }
		public static Color Maroon { get => maroon; }

		#endregion

		#region * NEON COLORS *

		private static Color neonWhite = GetColor ("#FFFFF0", 225);
		private static Color neonBlue = GetColor ("#0064FF");
		private static Color neonCyan = GetColor ("#00FFFF");
		private static Color neonGreen = GetColor ("#00D21F");
		private static Color neonYellow = GetColor ("#FFFF00");
		private static Color neonOrange = GetColor ("#F87E00");
		private static Color neonRed = GetColor ("#D71C1C");
		private static Color neonPink = GetColor ("#FF1493");
		private static Color neonViolet = GetColor ("#A000E5");

		public static Color NeonWhite { get => neonWhite; }
		public static Color NeonBlue { get => neonBlue; }
		public static Color NeonCyan { get => neonCyan; }
		public static Color NeonGreen { get => neonGreen; }
		public static Color NeonYellow { get => neonYellow; }
		public static Color NeonOrange { get => neonOrange; }
		public static Color NeonRed { get => neonRed; }
		public static Color NeonPink { get => neonPink; }
		public static Color NeonViolet { get => neonViolet; }


		#endregion

		#region * LIGHT COLORS *

		private static Color luxBlue = GetColor ("#649AFF");
		private static Color luxCyan = GetColor ("#6CE9F6");
		private static Color luxGreen = GetColor ("#71FF6A");
		private static Color luxYellow = GetColor ("#FFF278");
		private static Color luxOrange = GetColor ("#FF976A");
		private static Color luxRed = GetColor ("#FF6A75");
		private static Color luxPink = GetColor ("#FF69B4");
		private static Color luxViolet = GetColor ("#D569FF");
		private static Color luxGold = GetColor ("#FFD700");

		public static Color LuxBlue { get => luxBlue; }
		public static Color LuxCyan { get => luxCyan; }
		public static Color LuxGreen { get => luxGreen; }
		public static Color LuxYellow { get => luxYellow; }
		public static Color LuxOrange { get => luxOrange; }
		public static Color LuxRed { get => luxRed; }
		public static Color LuxPink { get => luxPink; }
		public static Color LuxViolet { get => luxViolet; }
		public static Color LuxGold { get => luxGold; }

		#endregion

		/// <summary>
		/// Get a color based on a given Hex Code.
		/// </summary>
		/// <param name="code">Hex Code.</param>
		/// <returns>The Color.</returns>
		private static Color GetColor (string code)
		{
			Color color;

			ColorUtility.TryParseHtmlString (code, out color);

			return color;
		}

		/// <summary>
		/// Get a color based on a given Hex Code.
		/// </summary>
		/// <param name="code">Hex Code.</param>
		/// <returns>The Color.</returns>
		private static Color GetColor (string code, float alpha)
		{
			Color color;

			ColorUtility.TryParseHtmlString (code, out color);

			color.a = alpha / 255;

			return color;
		}
	}

}