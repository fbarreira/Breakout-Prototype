using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class PauseGameUIHandler : MonoBehaviour
	{
		bool _isPaused;

		CanvasGroup canvasGroup;

		private void Awake ()
		{
			canvasGroup = GetComponent<CanvasGroup> ();
		}

		void Update ()
		{
			if (Input.GetKeyDown (KeyCode.Escape) && !GameManager.IsGameOver)
			{
				PauseGame ();
			}
		}

		private void OnDestroy ()
		{
			Time.timeScale = 1f;
		}

		private void PauseGame ()
		{
			_isPaused = !_isPaused;

			if (_isPaused) Show ();
			else Hide ();
		}

		private void Show ()
		{
			Time.timeScale = 0f;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			canvasGroup.alpha = 1f;
		}

		private void Hide ()
		{
			Time.timeScale = 1f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
			canvasGroup.alpha = 0f;
		}
	}

}