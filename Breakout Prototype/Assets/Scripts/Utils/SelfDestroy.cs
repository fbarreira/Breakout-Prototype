using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class SelfDestroy : MonoBehaviour
	{
		[SerializeField] float delay = 1f;

		private void Start ()
		{
			Destroy (gameObject, delay);
		}

	}

}