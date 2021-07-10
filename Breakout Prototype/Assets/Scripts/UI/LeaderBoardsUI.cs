using JustKrated.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class LeaderBoardsUI : MonoBehaviour
	{
		[SerializeField] GameObject highscorePrefab;
		[SerializeField] Transform parent;

		List<GameObject> higscoreList = new List<GameObject> ();

		private void Start ()
		{
			Setup ();
		}

		private void OnEnable ()
		{
			GameManager.OnGameOver += Setup;
			LevelSelector.OnLevelChanged += Setup;
		}

		private void OnDisable ()
		{
			GameManager.OnGameOver -= Setup;
			LevelSelector.OnLevelChanged -= Setup;
		}

		private void Setup ()
		{
			foreach (var go in higscoreList)
			{
				Destroy (go);
			}

			higscoreList.Clear ();

			int currentLevel = PlayerPrefsUtil.GetInt (Constants.P_CurrentLevel, 1);
			var leaderboards = DataManager.GetLevelData (currentLevel).Leaderboards;

			foreach (var highscore in leaderboards)
			{
				var highscoreGO = Instantiate (highscorePrefab, parent, false);
				highscoreGO.GetComponent<HighScoreField> ().Setup (highscore);
				higscoreList.Add (highscoreGO);
			}

		}
	}

}