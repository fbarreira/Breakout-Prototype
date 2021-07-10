using UnityEditor;
using Rox.BreakOut;

namespace JustKrated.Utils
{

	public static class DatabaseUtilEditor
	{
		private const string path = "Assets/Database/";
		private const string pathSystem = "Assets/Database/System/";
		private const string pathUtils = "Assets/Database/Utils/";
		private const string pathLists = "Assets/Database/Lists/";

		public static LevelDatabase GetLevelsDatabase ()
		{
			return AssetDatabase.LoadAssetAtPath<LevelDatabase> (path + "LevelDatabase.asset");
		}

	}

}