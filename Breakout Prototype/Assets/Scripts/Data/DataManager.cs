using JustKrated.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Rox.BreakOut
{
	[DefaultExecutionOrder (-1)]
	public class DataManager
	{
		static SaveData _data;

		static SaveData Data => GetSavedData ();

		private static SaveData GetSavedData ()
		{
			if (_data == null)
				LoadGameData ();

			if (_data == null)
				CreateSaveData ();

			return _data;
		}

		private static void SaveGameData ()
		{
			SaveSystem.Save (Data);
		}

		private static void LoadGameData ()
		{
			_data = SaveSystem.Load ();
		}

		private static void CreateSaveData ()
		{
			_data = new SaveData ();
			SaveSystem.Save (_data);
		}

		public static LevelData GetLevelData (int index) => Data.GetLevel (index);

		public static void UpdateLeaderboards (int levelIndex, string playerName, int score)
		{
			LevelData level = GetLevelData (levelIndex);
			var leaderboards = level.Leaderboards;

			leaderboards.Add (new ScoreData (playerName, score));
			var sortedList = leaderboards.OrderBy (x => x.Score).ToList ();

			if (sortedList.Count == 5)
			{
				sortedList.RemoveAt (5);
			}

			Data.UpdateLevel (new LevelData (levelIndex, sortedList));
			SaveGameData ();
		}
	}

}