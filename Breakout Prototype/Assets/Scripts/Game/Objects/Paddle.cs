using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[RequireComponent (typeof (Rigidbody))]
	public class Paddle : MonoBehaviour
	{
		[SerializeField] float speed = 5f;

		bool _canMove = true;
		float _input;

		Rigidbody _rigidBody;

		void Awake ()
		{
			_rigidBody = GetComponent<Rigidbody> ();
		}

		private void OnEnable ()
		{
			GameManager.OnGameOver += Lock;
		}

		private void OnDisable ()
		{
			GameManager.OnGameOver -= Lock;
		}

		void FixedUpdate ()
		{
			Move ();
		}

		private void Move ()
		{
			if (_canMove)
			{
				_input = Input.GetAxis ("Horizontal");
				_rigidBody.velocity = _input * speed * Vector2.right;
			}
		}

		private void Lock ()
		{
			_canMove = false;
		}
	}

}