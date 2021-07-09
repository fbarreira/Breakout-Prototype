using UnityEngine;
using UnityEngine.SceneManagement;

namespace JustKrated.Utils
{
	public class InstantiatorUtil : MonoSingleton<InstantiatorUtil>
	{
		readonly string persistentScene = "Persistent";

		private static bool isLoaded;

		protected override void Init ()
		{
			CheckPersistent ();
		}

		private void CheckPersistent ()
		{
			if (!isLoaded)
			{
				isLoaded = true;

				SceneManager.LoadScene (persistentScene, LoadSceneMode.Additive);
			}
		}
	}
}
