using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[System.Serializable]
	public struct ScoreData
	{
		public string playerName;
		public int score;

		public string PlayerName => playerName;
		public int Score => score;

		public ScoreData (string playerName, int score)
		{
			this.playerName = playerName;
			this.score = score;
		}
	}

}