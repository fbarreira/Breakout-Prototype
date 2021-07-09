using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[System.Serializable]
	public class Level
	{
		[SerializeField] int level;
		[SerializeField] int[,] map;

		public int Index => level;
		public int[,] Map => map;

		public Level (int level, int[,] map)
		{
			this.level = level;
			this.map = map;
		}
	}

}