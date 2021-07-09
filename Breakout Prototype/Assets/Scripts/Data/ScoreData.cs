using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public struct ScoreData
	{
		string playerName;
		int score;

		public string PlayerName => PlayerName;
		public int Score => score;

		public ScoreData (string playerName, int score)
		{
			this.playerName = playerName;
			this.score = score;
		}
	}

}