using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Rox.BreakOut
{
	[RequireComponent (typeof (Button))]
	public class ButtonLoadScene : MonoBehaviour
	{
		[SerializeField] string scene;

		Button button;

		private void Awake ()
		{
			button = GetComponent<Button> ();
			button.onClick.AddListener (LoadScene);
		}

		private void LoadScene ()
		{
			SceneManager.LoadScene (scene);
		}
	}

}