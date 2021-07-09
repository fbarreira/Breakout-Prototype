using UnityEngine;

namespace JustKrated.Utils
{

	public static class ColorUtil
	{
		public static Color GetAlphaNormalized (Color color, float value)
		{
			Color tempColor = color;
			tempColor.a = value;
			return tempColor;
		}

		public static Color GetAlpha (Color color, int value)
		{
			Color tempColor = color;
			tempColor.a = GetValueNormalized (value);
			return tempColor;
		}

		public static float GetValueNormalized (int value)
		{
			return MathUtil.Normalize01 (value, 0, 255);
		}
	}

}