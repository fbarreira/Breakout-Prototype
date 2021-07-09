using System;
using UnityEngine;

namespace JustKrated.Utils
{
	// Extension of Player Prefs to allow saving booleans, chars.
	// Use GetIntIncremented to always get a new unique integer. Value is incremented by 1 on every call.
	public static class PlayerPrefsUtil
	{

		#region * INTEGERS *

		/// <summary>
		/// Return the incremental value corresponding to key in the preference file if it exists.
		/// </summary>
		public static int GetIntIncremented (string key)
		{
			int index = GetInt (key, -1);
			SetInt (key, index + 1);
			return index + 1;
		}

		/// <summary>
		/// Return the value corresponding to key in the preference file if it exists.
		/// </summary>
		public static int GetInt (string key, int defaultValue = 0)
		{
			return PlayerPrefs.GetInt (key, defaultValue);
		}

		/// <summary>
		/// Sets the value of the preference identified by the key.
		/// </summary>
		public static void SetInt (string key, int value)
		{
			PlayerPrefs.SetInt (key, value);
			PlayerPrefs.Save ();
		}

		#endregion

		#region * FLOATS *

		/// <summary>
		/// Return the value corresponding to key in the preference file if it exists.
		/// </summary>
		public static float GetFloat (string key, float defaultValue = 0)
		{
			return PlayerPrefs.GetFloat (key, defaultValue);
		}

		/// <summary>
		/// Sets the value of the preference identified by the key.
		/// </summary>
		public static void SetFloat (string key, float value)
		{
			PlayerPrefs.SetFloat (key, value);
			PlayerPrefs.Save ();
		}

		#endregion

		#region * STRINGS *

		/// <summary>
		/// Return the value corresponding to key in the preference file if it exists.
		/// </summary>
		public static string GetString (string key, string defaultValue = "")
		{
			return PlayerPrefs.GetString (key, defaultValue);
		}

		/// <summary>
		/// Sets the value of the preference identified by the key.
		/// </summary>
		public static void SetString (string key, string value)
		{
			PlayerPrefs.SetString (key, value);
			PlayerPrefs.Save ();
		}

		#endregion

		#region * BOOLS *

		/// <summary>
		/// Return the boolean value corresponding to key in the preference file if it exists.
		/// </summary>
		public static bool GetBool (string key)
		{
			if (PlayerPrefs.HasKey (key))
			{
				int i = GetInt (key);

				if (i != 0 && i != 1)
				{
					Debug.LogWarning ("Saved value for {0} should be either 0 or 1. Returning FALSE");
					return false;
				}

				return IntToBool (i);
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Return the boolean value corresponding to key in the preference file if it exists.
		/// </summary>
		public static bool GetBool (string key, bool defaultValue)
		{
			int _value = BoolToInt (defaultValue);
			int i = GetInt (key, _value);

			if (i != 0 && i != 1)
			{
				Debug.LogWarning ("Saved value for {0} should be either 0 or 1. Returning FALSE");
				return false;
			}

			return IntToBool (i);
		}

		/// <summary>
		/// Sets the boolean value of the preference identified by the key.
		/// </summary>
		public static void SetBool (string key, bool value)
		{
			int i = BoolToInt (value);

			SetInt (key, i);
		}

		private static int BoolToInt (bool b)
		{
			return b ? 1 : 0;
		}

		private static bool IntToBool (int i)
		{
			return i == 1;
		}

		#endregion

		#region * CHARS *

		/// <summary>
		/// Return the char value corresponding to key in the preference file if it exists.
		/// </summary>
		public static char GetChar (string key, char defaultValue = char.MinValue)
		{
			string s = GetString (key);

			if (char.TryParse (s, out char c))
			{
				return c;
			}
			else
			{
				return defaultValue;
			}
		}

		/// <summary>
		/// Sets the boolean value of the preference identified by the key.
		/// </summary>
		public static void SetChar (string key, char value)
		{
			SetString (key, value.ToString ());
		}

		#endregion

		public static string GetUniqueID (string key)
		{
			int index = GetIntIncremented (key);

			DateTime theTime = DateTime.Now;
			string datetime = theTime.ToString ("yyyyMMddHHmmss");
			return string.Format ("igwrite.{0}_{1}-{2}", key.ToLower (), datetime, index);
		}

		public static void PopulatePlayerPrefs ()
		{
			///TO FILL
			///Add your own preferences

			PlayerPrefs.Save ();
		}
	}
}
