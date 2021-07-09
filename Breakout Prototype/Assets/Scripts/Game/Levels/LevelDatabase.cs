using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[CreateAssetMenu (fileName = "LevelDatabase", menuName = "ScriptableObjects/Level Database", order = 1)]
	public class LevelDatabase : ScriptableObject
	{
		[SerializeField] List<Level> levels = new List<Level> ();

		List<Level> Levels => levels;

		LevelDatabase ()
		{
			AddLevel1 ();
			AddLevel2 ();
			AddLevel3 ();
		}

		public int[,] GetMap (int levelIndex)
		{
			return levels.Find (x => x.Index == levelIndex).Map;
		}

		private void AddLevel1 ()
		{
			int[,] map =
{
				{0,0,0,0,0,0,0,0,0},
				{2,2,2,2,2,2,2,2,2},
				{4,4,4,4,4,4,4,4,4},
				{3,3,3,3,3,3,3,3,3},
				{1,1,1,1,1,1,1,1,1},
				{0,0,0,0,0,0,0,0,0},
			};

			levels.Add (new Level (1, map));
		}

		private void AddLevel2 ()
		{
			int[,] map =
{
				{5,4,3,2,1,2,3,4,5},
				{2,2,2,4,4,4,2,2,2},
				{3,3,3,4,5,4,3,3,3},
				{2,2,2,4,4,4,2,2,2},
				{0,0,0,0,0,0,0,0,0},
				{0,0,0,0,0,0,0,0,0},
			};

			levels.Add (new Level (2, map));
		}

		private void AddLevel3 ()
		{
			int[,] map =
{
				{0,0,6,5,5,5,6,0,0},
				{4,2,2,4,4,4,2,2,4},
				{5,4,4,3,6,3,4,4,5},
				{4,6,3,0,0,0,0,6,4},
				{2,1,2,1,2,1,2,2,1},
				{1,0,1,0,1,0,1,0,1},
			};

			levels.Add (new Level (3, map));
		}

	}

}