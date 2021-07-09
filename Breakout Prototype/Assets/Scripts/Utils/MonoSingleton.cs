using UnityEngine;

namespace JustKrated.Utils
{
	public class MonoSingleton<T> : MonoBehaviourUtil where T : MonoSingleton<T>
	{
		public bool instantiateOnAwake = true;
		public bool dontDestroyOnLoad;

		private static T _instance;
		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
					Debug.LogWarning (typeof (T).ToString () + " Is NULL. Trying to find instance...");
					_instance = FindObjectOfType<T> ();

					if (_instance == null)
					{
						Debug.LogWarning (typeof (T).ToString () + " Is NULL. Could not find or create.");
					}
				}

				return _instance;
			}
		}

		private void Awake ()
		{
			if (_instance != null)
			{
				Debug.Log (typeof (T).ToString () + " Already exists. Destroying duplicate...");
				Destroy (gameObject);
			}
			else
			{
				_instance = this as T;

				if (dontDestroyOnLoad) DontDestroyOnLoad (gameObject);
				if (instantiateOnAwake) Init ();
			}
		}

		protected virtual void Init ()
		{
			//optional to override
		}
	}
}
