using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using JustKrated.Utils;

namespace Rox.BreakOut
{


	public class LevelsDatabaseEditor : EditorWindow
	{

		/// <summary> Minimum Window width </summary>
		private const float WINDOW_MIN_WIDTH = 200f;
		/// <summary> Minimum Window height </summary>
		private const float WINDOW_MIN_HEIGHT = 400;

		LevelDatabase database;

		[MenuItem ("Tools/Levels Editor", false, 251)]
		public static void GetWindow ()
		{
			LevelsDatabaseEditor editor = GetWindow<LevelsDatabaseEditor> ("Levels Editor", true);
			editor.minSize = new Vector2 (WINDOW_MIN_WIDTH, WINDOW_MIN_HEIGHT);
		}

		private void Awake ()
		{
			database = DatabaseUtilEditor.GetLevelsDatabase ();
		}

		void OnEnable ()
		{
			hideFlags = HideFlags.HideAndDontSave;
		}

		private void OnGUI ()
		{
			if (GUILayout.Button ("Create Levels"))
			{
				CreateDatabase ();
			}
		}

		private void CreateDatabase ()
		{
			AddLevel1 ();
			AddLevel2 ();
			AddLevel3 ();
			AddLevel4 ();
			AddLevel5 ();
		}

		private void AddLevel1 ()
		{
			int[,] map =
{
				{0,0,0,0,0,0,0,0,0},
				{6,6,6,6,6,6,6,6,6},
				{1,1,1,1,1,1,1,1,1},
				{2,2,2,2,2,2,2,2,2},
				{3,3,3,3,3,3,3,3,3},
				{2,2,2,2,2,2,2,2,2},
				{1,1,1,1,1,1,1,1,1},
				{0,0,0,0,0,0,0,0,0},
				{0,0,0,0,0,0,0,0,0},
			};

			AddLevel (new Level (1, map));
		}

		private void AddLevel2 ()
		{
			int[,] map =
			{
				{0,0,0,1,1,1,0,0,0},
				{0,0,1,2,3,2,1,0,0},
				{0,1,2,3,4,3,2,1,0},
				{1,2,3,4,5,4,3,2,1},
				{1,2,3,4,6,4,3,2,1},
				{1,2,3,4,5,4,3,2,1},
				{0,1,2,3,4,3,2,1,0},
				{0,0,1,2,3,2,1,0,0},
				{0,0,0,1,1,1,0,0,0},
			};

			AddLevel (new Level (2, map));
		}

		private void AddLevel3 ()
		{
			int[,] map =
{
				{1,2,3,4,5,4,3,2,1},
				{2,1,2,3,4,3,2,1,2},
				{6,2,1,2,3,2,1,2,6},
				{6,6,2,1,2,1,2,6,6},
				{6,6,6,2,1,2,6,6,6},
				{6,6,2,1,0,1,2,6,6},
				{6,2,1,0,0,0,1,2,6},
				{2,1,0,0,0,0,0,1,2},
				{1,0,0,0,0,0,0,0,1},
			};

			AddLevel (new Level (3, map));
		}

		private void AddLevel4 ()
		{
			int[,] map =
			{
				{5,5,5,5,5,5,5,5,5},
				{4,4,4,4,6,4,4,4,4},
				{0,0,0,0,0,0,0,0,0},
				{3,3,3,3,6,3,3,3,3},
				{0,0,0,0,0,0,0,0,0},
				{2,2,2,2,6,2,2,2,2},
				{0,0,0,0,0,0,0,0,0},
				{1,1,1,1,6,1,1,1,1},
				{0,0,0,0,0,0,0,0,0},
			};

			AddLevel (new Level (4, map));
		}

		private void AddLevel5 ()
		{
			int[,] map =
			{
				{3,3,3,0,0,0,3,3,3},
				{3,5,3,0,6,0,3,5,3},
				{3,3,3,0,0,0,3,3,3},
				{0,0,0,2,2,2,0,0,0},
				{0,6,0,2,5,2,0,6,0},
				{0,0,0,2,2,2,0,0,0},
				{1,1,1,0,0,0,1,1,1},
				{1,4,1,0,6,0,1,4,1},
				{1,1,1,0,0,0,1,1,1},
			};

			AddLevel (new Level (5, map));
		}

		private void AddLevel (Level level)
		{
			EditorUtility.SetDirty (database);
			database.AddLevel (level);
			EditorUtility.SetDirty (database);
		}
	}

}