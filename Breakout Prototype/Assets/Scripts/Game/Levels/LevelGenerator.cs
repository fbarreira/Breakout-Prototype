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

		int _currentLevel = 1;

		void Awake ()
		{

		}

		void Start ()
		{
			PopulateLevel ();
		}

		private void PopulateLevel ()
		{
			var map = database.GetMap (_currentLevel);

			Vector2 origin = new Vector2 (-4f, 3.5f);

			float x = 0;
			float y = 0;

			for (int i = 0; i < map.GetLength (0); i++)
			{
				y = origin.y + 1 * i;

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

			BlocksTotal++;
		}

		private GameObject GetBrickPrefab (int index) => (index > 0) ? brickPrefabs[index - 1] : null;
	}

}