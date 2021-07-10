using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JustKrated.Utils;

namespace Rox.BreakOut
{
	[RequireComponent (typeof (TMP_InputField))]
	public class InputNameUIHandler : MonoBehaviour
	{
		[SerializeField] TMP_InputField inputField;

		private void Awake ()
		{
			inputField = GetComponent<TMP_InputField> ();
			inputField.onEndEdit.AddListener (UpdateName);
		}


		private void UpdateName (string value)
		{
			if (string.IsNullOrEmpty (value) || string.IsNullOrWhiteSpace (value))
			{
				return;
			}

			PlayerPrefsUtil.SetString (Constants.P_PlayerName, value);
		}
	}

}