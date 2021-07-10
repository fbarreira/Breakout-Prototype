using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class LevelGenerator : MonoBehaviour
	{
		[SerializeField] LevelDatabase database;

		[SerializeField] List<GameObject> brickPrefabs = new List<GameObject> ();

		public int BlocksTotal { get; private set; }

		public void Setup (int currentLevel)
		{
			var map = database.GetMap (currentLevel);

			Vector2 origin = new Vector2 (-4f, 8.75f);

			float x = 0;
			float y = 0;

			for (int i = 0; i < map.GetLength (0); i++)
			{
				y = origin.y - .5f * i;

				for (int j = 0; j < map.GetLength (1); j++)
				{
					x = origin.x + 1 * j;
					Vector3 spawnPos = new Vector3 (x, y, 0.5f);
					InstantiateBrick (map[i, j], spawnPos);
				}
			}
		}

		private void InstantiateBrick (int index, Vector3 position)
		{
			if (index == 0) return;

			var prefab = GetBrickPrefab (index);

			Instantiate (prefab, position, Quaternion.identity);

			if (index < 6)
				BlocksTotal++;
		}

		private GameObject GetBrickPrefab (int index) => (index > 0) ? brickPrefabs[index - 1] : null;
	}

}