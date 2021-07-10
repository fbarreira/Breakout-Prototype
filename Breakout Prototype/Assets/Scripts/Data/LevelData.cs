using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[System.Serializable]

	public class LevelData
	{
		public int level;
		public List<ScoreData> highscores = new List<ScoreData> ();

		public int Index => level;

		public List<ScoreData> Leaderboards => highscores;

		public LevelData (int level)
		{
			this.level = level;
			highscores = new List<ScoreData> ();
		}

		public LevelData (int level, List<ScoreData> highscores)
		{
			this.level = level;
			this.highscores = highscores;
		}
	}

}