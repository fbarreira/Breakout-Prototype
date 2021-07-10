using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Rox.BreakOut
{
	[DefaultExecutionOrder (100)]
	[RequireComponent (typeof (Toggle))]
	public class LevelToggleUI : MonoBehaviour
	{
		[SerializeField] int index;
		[SerializeField] TMP_Text label;

		Toggle _toggle;

		public delegate void HandleLevelSelection (int i);

		public static event HandleLevelSelection OnLevelSelected;

		void Awake ()
		{
			_toggle = GetComponent<Toggle> ();
			_toggle.onValueChanged.AddListener (OnToggle);
		}

		private void Start ()
		{
			label.text = index.ToString ();
		}

		private void OnToggle (bool value)
		{
			if (value)
			{
				OnLevelSelected?.Invoke (index);
			}
		}

	}

}