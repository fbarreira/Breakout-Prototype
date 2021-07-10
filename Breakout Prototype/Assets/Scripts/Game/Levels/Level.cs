using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[System.Serializable]
	public class Level
	{
		[System.Serializable]
		public class MapLine
		{
			public List<int> elements = new List<int> ();
		}

		[SerializeField] int level;
		[SerializeField] Sprite thumbnail;
		[SerializeField] List<MapLine> map = new List<MapLine> ();

		public int Index => level;
		public int[,] Map => GetMap ();

		public Sprite Thumbnail => thumbnail;

		public Level (int level, int[,] mapArray)
		{
			this.level = level;

			// Convert 2D array to serialized map
			for (int i = 0; i < 9; i++)
			{
				map.Add (new MapLine ());

				for (int j = 0; j < 9; j++)
				{
					map[i].elements.Add (mapArray[i, j]);
				}
			}
		}

		private int[,] GetMap ()
		{
			// Convert serialized map to jagged array
			int[][] mapArray = new int[9][];
			for (int i = 0; i < map.Count; i++)
			{
				mapArray[i] = map[i].elements.ToArray ();
			}

			// Convert jagged array to 2D array
			var result = new int[9, 9];
			for (int i = 0; i < 9; ++i)
				for (int j = 0; j < 9; ++j)
					result[i, j] = mapArray[i][j];

			return result;
		}
	}

}