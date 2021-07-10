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

		public Level GetLevel (int index) => levels.Find (x => x.Index == index);

		public int[,] GetMap (int levelIndex)
		{
			return levels.Find (x => x.Index == levelIndex).Map;
		}

		public void AddLevel (Level level)
		{
			levels.Add (level);
		}

	}

}