using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rox.BreakOut
{
	[RequireComponent (typeof (Rigidbody))]
	public class Paddle : MonoBehaviour
	{
		[SerializeField] float speed = 5f;
		[SerializeField] GameObject ballProp;

		bool _canMove = true;
		float _input;

		Rigidbody _rigidBody;

		void Awake ()
		{
			_rigidBody = GetComponent<Rigidbody> ();
		}

		void Start ()
		{

		}

		private void OnEnable ()
		{
			///TODO: Add listener to onGameOver
		}

		private void OnDisable ()
		{

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
	}

}