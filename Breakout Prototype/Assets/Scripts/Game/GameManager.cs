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

	public class GameManager : MonoBehaviour
	{
		GameState _gameState;

		int _score;
		int _blocksDestroyed;


		GameUIHandler ui;
		LevelGenerator levelGenerator;

		public delegate void HandleGameState ();

		public static event HandleGameState OnGameWon;
		public static event HandleGameState OnGameLost;

		void Awake ()
		{
			ui = GetComponent<GameUIHandler> ();
			levelGenerator = GetComponent<LevelGenerator> ();

			SetState (GameState.Set);
		}

		void Start ()
		{

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

			ShootBall ();
		}

		private void ShootBall ()
		{
			if (Input.GetKeyDown (KeyCode.Space) && IsGameSet)
			{
				SetState (GameState.Playing);
				EventManager.TriggerEvent (Constants.E_OnShootBall);
			}
		}

		private void SetState (GameState state)
		{
			_gameState = state;
		}

		private void HandleBallDestroyed ()
		{
			Debug.Log ("Game Over");
			OnGameLost?.Invoke ();
		}

		private void HandleBrickDestroyed (int points)
		{
			_blocksDestroyed++;
			_score += points;
			ui.UpdateScore (_score);

			if (_blocksDestroyed == levelGenerator.BlocksTotal)
			{
				OnGameWon?.Invoke ();
			}
		}

		public bool IsGameSet => _gameState == GameState.Set;
		public bool IsGamePlaying => _gameState == GameState.Playing;
		public bool IsGameOver => _gameState == GameState.Over;


	}

}