using UnityEditor;
using UnityEngine;

namespace JustKrated.Utils
{
	public class SaveDataEditor : EditorWindow
	{
		/// <summary> Minimum Window width </summary>
		private const float WINDOW_MIN_WIDTH = 200f;
		/// <summary> Minimum Window height </summary>
		private const float WINDOW_MIN_HEIGHT = 400;

		void OnEnable ()
		{
			hideFlags = HideFlags.HideAndDontSave;
		}

		[MenuItem ("Tools/SaveData Editor", false, 251)]
		public static void GetWindow ()
		{
			SaveDataEditor editor = GetWindow<SaveDataEditor> ("PlayerPrefs Editor", true);
			editor.minSize = new Vector2 (WINDOW_MIN_WIDTH, WINDOW_MIN_HEIGHT);
		}

		private void OnGUI ()
		{
			EditorGUILayout.Space ();

			if (GUILayout.Button ("Erase All Prefs"))
			{
				PlayerPrefs.DeleteAll ();
			}

			EditorGUILayout.Space ();

			if (GUILayout.Button ("Reset Prefs"))
			{
				PlayerPrefsUtil.PopulatePlayerPrefs ();
			}

			EditorGUILayout.Space ();

			if (GUILayout.Button ("Delete Save File"))
			{
				FileUtil.DeleteFileOrDirectory (System.IO.Path.Combine (Application.persistentDataPath, "save" + ".json"));
			}

			EditorGUILayout.Space ();

		}
	}
}
