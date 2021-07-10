using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[System.Serializable]
	public class SaveData
	{
		public List<LevelData> levels = new List<LevelData> ();

		public void AddLevel (LevelData level)
		{
			if (ContainsLevel (level.Index)) return;

			levels.Add (level);
		}

		public void UpdateLevel (LevelData level)
		{
			if (ContainsLevel (level.Index))
			{
				int listIndex = levels.FindIndex (x => x.Index == level.Index);
				levels[listIndex] = level;
			}
		}

		public LevelData GetLevel (int index)
		{
			var levelData = levels.Find (x => x.Index == index);

			if (levelData == null)
			{
				levelData = new LevelData (index);
				levels.Add (levelData);
			}

			return levelData;
		}

		public bool ContainsLevel (int index) => GetLevel (index) != null;
	}

}