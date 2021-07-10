using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JustKrated.Utils;

namespace Rox.BreakOut
{

	public class LevelSelector : MonoBehaviour
	{
		[SerializeField] LevelDatabase database;

		[SerializeField] TMP_Text levelTitle;
		[SerializeField] Image levelIcon;

		int _currentLevel = 0;

		public delegate void HandleLevelSelection ();
		public static event HandleLevelSelection OnLevelChanged;

		private void Awake ()
		{

		}

		void Start ()
		{
			SelectLevel (1);
		}

		private void OnEnable ()
		{
			LevelToggleUI.OnLevelSelected += SelectLevel;
		}

		private void OnDisable ()
		{
			LevelToggleUI.OnLevelSelected -= SelectLevel;
		}

		private void SelectLevel (int index)
		{
			_currentLevel = index;
			Level level = database.GetLevel (_currentLevel);

			levelTitle.text = string.Format ("Level {0}", level.Index);
			levelIcon.sprite = level.Thumbnail;

			PlayerPrefsUtil.SetInt (Constants.P_CurrentLevel, _currentLevel);

			OnLevelChanged?.Invoke ();
		}
	}

}