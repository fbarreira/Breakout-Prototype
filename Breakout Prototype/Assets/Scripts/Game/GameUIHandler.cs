using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Rox.BreakOut
{
	[DefaultExecutionOrder (1000)]
	public class GameUIHandler : MonoBehaviour
	{
		[SerializeField] TMP_Text scoreDisplay;
		[SerializeField] TMP_Text timeDisplay;

		public void UpdateScore (int score)
		{
			scoreDisplay.text = string.Format ("Score: {0}", score);
		}

	}

}