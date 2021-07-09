
namespace JustKrated.Utils
{

	public static class MathUtil
	{
		/// <summary>
		/// Normalizes a value within a given interval.
		/// </summary>
		/// <param name="value">The value to be normalized.</param>
		/// <param name="min">The minimum value for the interval.</param>
		/// <param name="max">The maximum value for the interval.</param>
		/// <returns>The normalized value. <i>[Returns 0 otherwise.]</i></returns>
		public static float Normalize01 (float value, float min, float max)
		{
			if (min >= max) return 0;

			return (value - min) / (max - min);
		}
	}

}