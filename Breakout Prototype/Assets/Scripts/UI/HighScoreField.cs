using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Rox.BreakOut
{

	public class HighScoreField : MonoBehaviour
	{
		[SerializeField] TMP_Text nameDisplay;
		[SerializeField] TMP_Text scoreDisplay;

		public void Setup (ScoreData scoreData)
		{
			nameDisplay.text = scoreData.PlayerName;
			scoreDisplay.text = scoreData.Score.ToString ();
		}

		public void Setup (string name, string score)
		{
			nameDisplay.text = name;
			scoreDisplay.text = score;
		}
	}

}