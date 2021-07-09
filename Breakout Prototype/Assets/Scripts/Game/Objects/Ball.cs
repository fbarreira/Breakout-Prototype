using JustKrated.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{

	public class Ball : MonoBehaviour
	{
		[SerializeField] float speed = 3f;
		[SerializeField] GameObject trail;

		Rigidbody _rigidBody;
		Collider _collider;

		public delegate void HandleBallEvent ();

		public static event HandleBallEvent OnDestroyed;

		void Awake ()
		{
			_rigidBody = GetComponent<Rigidbody> ();
			_collider = GetComponent<Collider> ();
		}

		private void OnEnable ()
		{
			EventManager.AddListener (Constants.E_OnShootBall, Shoot);
		}

		private void OnDisable ()
		{
			EventManager.RemoveListener (Constants.E_OnShootBall, Shoot);
		}

		private void Shoot ()
		{
			trail.SetActive (true);
			transform.parent = null;
			_rigidBody.isKinematic = false;
			_rigidBody.AddForce (Vector3.up * speed, ForceMode.VelocityChange);
		}

		private void OnCollisionEnter (Collision other)
		{
			if (other.gameObject.CompareTag (Constants.T_Paddle))
			{
				BouncePaddle (other.transform);
			}
			else
			{
				if (other.gameObject.CompareTag (Constants.T_Brick))
				{
					other.gameObject.GetComponent<Brick> ().Destroy ();
				}

				Bounce ();
			}
		}

		private void OnTriggerEnter (Collider other)
		{
			if (other.gameObject.CompareTag (Constants.T_DestroyZone))
			{
				OnDestroyed?.Invoke ();
				Destroy (gameObject);
			}
		}

		private void Bounce ()
		{
			var velocity = _rigidBody.velocity;

			SetVelocity (velocity);
		}

		private void BouncePaddle (Transform paddle)
		{
			//  Get x value based on where the ball hits the paddle
			//	1  -0.5  0  0.5   1  <- x value
			//	===================  <- paddle
			float x = (transform.position.x - paddle.position.x) / _collider.bounds.size.x;

			Vector2 direction = new Vector2 (x, 1f).normalized;

			_rigidBody.velocity = direction * speed;
		}

		private void SetVelocity (Vector3 velocity)
		{
			//Debug.Log ("velocity: " + velocity);
			//Debug.Log ("normalized: " + velocity.normalized);
			//Debug.Log ("Dot y: " + Vector3.Dot (velocity.normalized, Vector3.up));
			//Debug.Log ("Dot x: " + Vector3.Dot (velocity.normalized, Vector3.right));

			// Check if ball is not stuck vertically
			if (Vector3.Dot (velocity.normalized, Vector3.up) < 0.5f)
			{
				velocity += velocity.y > 0 ? Vector3.up * 0.5f : Vector3.down * 0.5f;
			}

			// Check if ball is not stuck horizontally
			if (Vector3.Dot (velocity.normalized, Vector3.right) < 0.5f)
			{
				velocity += velocity.x > 0 ? Vector3.right * 0.5f : Vector3.left * 0.5f;
			}

			// Check if velocity is greater than speed
			if (velocity.magnitude > speed)
			{
				velocity = velocity.normalized * speed;
			}

			_rigidBody.velocity = velocity;
		}


	}

}