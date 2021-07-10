using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Rox.BreakOut
{

	public static class SaveSystem
	{
		const string fileName = "save";

		public static void Save (SaveData data)
		{
			var jsonData = JsonUtility.ToJson (data, true);
			File.WriteAllText (GetPath (), jsonData);
		}

		public static SaveData Load ()
		{
			var path = GetPath ();

			if (File.Exists (path))
			{
				var jsonData = File.ReadAllText (path);
				return JsonUtility.FromJson<SaveData> (jsonData);
			}

			return null;
		}

		private static string GetPath ()
		{
			return Path.Combine (Application.persistentDataPath, fileName + ".json");
		}
	}

}