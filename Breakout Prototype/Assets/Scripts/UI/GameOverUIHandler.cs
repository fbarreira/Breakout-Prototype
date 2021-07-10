using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class GameOverUIHandler : MonoBehaviour
	{
		CanvasGroup canvasGroup;

		private void Awake ()
		{
			canvasGroup = GetComponent<CanvasGroup> ();
		}

		private void OnEnable ()
		{
			GameManager.OnGameOver += Show;
		}

		private void OnDisable ()
		{
			GameManager.OnGameOver -= Show;
		}

		private void Show ()
		{
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			canvasGroup.alpha = 1f;
		}
	}

}