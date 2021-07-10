using JustKrated.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	public enum GameState
	{
		Set,
		Playing,
		Over
	}

	public class GameManager : MonoSingleton<GameManager>
	{
		[SerializeField] int maxTime = 600;

		GameState _gameState;

		int _currentLevel;
		int _score;
		int _blocksDestroyed;
		int _timeLeft;

		GameUIHandler ui;
		LevelGenerator levelGenerator;

		public delegate void HandleGameState ();

		public static event HandleGameState OnGameOver;

		protected override void Init ()
		{
			ui = GetComponent<GameUIHandler> ();
			levelGenerator = GetComponent<LevelGenerator> ();

			SetState (GameState.Set);
		}

		void Start ()
		{
			_currentLevel = PlayerPrefsUtil.GetInt (Constants.P_CurrentLevel, 1);
			//_currentLevel = 1;
			_timeLeft = maxTime;

			ui.UpdateScore (0);
			ui.UpdateTime (_timeLeft);

			levelGenerator.Setup (_currentLevel);
		}

		private void OnEnable ()
		{
			Ball.OnDestroyed += HandleBallDestroyed;
			Brick.OnDestroyed += HandleBrickDestroyed;
		}

		private void OnDisable ()
		{
			Ball.OnDestroyed -= HandleBallDestroyed;
			Brick.OnDestroyed -= HandleBrickDestroyed;
		}

		void Update ()
		{
			if (IsGameOver) return;

			if (_timeLeft == 0) SetGameOver ();

			ShootBall ();
		}

		private void ShootBall ()
		{
			if (Input.GetKeyDown (KeyCode.Space) && IsGameSet)
			{
				SetState (GameState.Playing);
				EventManager.TriggerEvent (Constants.E_OnShootBall);

				StartCoroutine (UpdateTimer ());
			}
		}

		private void SetState (GameState state)
		{
			_gameState = state;
		}

		private void HandleBallDestroyed ()
		{
			SetGameOver ();
		}

		private void HandleBrickDestroyed (int points)
		{
			_blocksDestroyed++;
			_score += points;
			ui.UpdateScore (_score);

			if (_blocksDestroyed == levelGenerator.BlocksTotal)
			{
				_score += _timeLeft;

				SetGameOver ();
			}
		}

		private IEnumerator UpdateTimer ()
		{
			while (IsGamePlaying)
			{
				_timeLeft--;
				ui.UpdateTime (_timeLeft);

				yield return new WaitForSeconds (1f);
			}
		}

		private void SetGameOver ()
		{
			string player = PlayerPrefsUtil.GetString (Constants.P_PlayerName, "Player");
			DataManager.UpdateLeaderboards (_currentLevel, player, _score);

			SetState (GameState.Over);
			OnGameOver?.Invoke ();
		}

		public static bool IsGameSet => Instance._gameState == GameState.Set;
		public static bool IsGamePlaying => Instance._gameState == GameState.Playing;
		public static bool IsGameOver => Instance._gameState == GameState.Over;


	}

}