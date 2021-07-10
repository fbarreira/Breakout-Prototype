using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rox.BreakOut
{

	public class MenuUIHandler : MonoBehaviour
	{
		[SerializeField] CanvasGroup mainCanvas;
		[SerializeField] CanvasGroup levelsCanvas;

		void Awake ()
		{

		}

		void Start ()
		{

		}

		void Update ()
		{

		}

		public void OpenLevelSelection ()
		{
			SwitchWindows (mainCanvas, levelsCanvas);
		}

		public void ReturnToMenu ()
		{
			SwitchWindows (levelsCanvas, mainCanvas);
		}

		public void PlayLevel ()
		{
			SceneManager.LoadScene ("Game");
		}

		private void SwitchWindows (CanvasGroup oldWindow, CanvasGroup newWindow)
		{
			CloseWindow (oldWindow);
			OpenWindow (newWindow);
		}

		private void OpenWindow (CanvasGroup canvasGroup)
		{
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			canvasGroup.alpha = 1f;
		}

		private void CloseWindow (CanvasGroup canvasGroup)
		{
			canvasGroup.alpha = 0f;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
		}

		public void QuitGame ()
		{
			Application.Quit ();
		}
	}

}