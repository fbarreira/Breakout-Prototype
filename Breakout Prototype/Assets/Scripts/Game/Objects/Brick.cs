using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class Brick : MonoBehaviour
	{
		[SerializeField] bool isDestructable = true;
		[SerializeField] int life = 1;
		[SerializeField] int points;

		[SerializeField] GameObject particlesPrefab;

		public delegate void HandleBrickEvent (int p);

		public static event HandleBrickEvent OnDestroyed;

		public void Destroy ()
		{
			if (!isDestructable) return;

			life--;

			if (life == 0)
			{
				Instantiate (particlesPrefab, transform.position, Quaternion.identity);
				OnDestroyed?.Invoke (points);

				Destroy (gameObject, 0.2f);
			}
		}
	}

}