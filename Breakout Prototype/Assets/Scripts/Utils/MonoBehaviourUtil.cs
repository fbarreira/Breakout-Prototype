using System;
using UnityEngine;

namespace JustKrated.Utils
{

	public class MonoBehaviourUtil : MonoBehaviour
	{
		[Header ("MONO PARAMETERS")]
		public bool debug;
		public string logTag = "TAG";

		/// <summary>
		/// Invokes the action in time seconds.
		/// </summary>
		protected void Invoke (Action action, float time)
		{
			Invoke (action.Method.Name, time);
		}

		protected void InvokeRepeating (Action action, float repetRate, float time = 0f)
		{
			InvokeRepeating (action.Method.Name, repetRate, time);
		}

		protected void CancelInvoke (Action action)
		{
			CancelInvoke (action.Method.Name);
		}

		#region * LOGGING *

		/// <summary>
		/// Logs a message to Unity Console.
		/// </summary>
		protected void Log (object message, bool overrideDebug = false)
		{
			string _message = string.Format ("[{0}] {1}", logTag, message);

			if (debug || overrideDebug) Debug.Log (_message);
		}

		/// <summary>
		/// Logs a formatted message to Unity Console.
		/// </summary>
		protected void LogFormat (string format, params object[] args)
		{
			string _format = string.Format ("[{0}] ", logTag) + format;

			if (debug) Debug.LogFormat (_format, args);
		}

		/// <summary>
		/// Logs a formatted message to Unity Console.
		/// </summary>
		protected void LogFormatOverride (string format, params object[] args)
		{
			string _format = string.Format ("[{0}] ", logTag) + format;

			Debug.LogFormat (_format, args);
		}

		/// <summary>
		/// Logs a warning message to Unity Console.
		/// </summary>
		protected void LogWarning (object message, bool overrideDebug = false)
		{
			string _message = string.Format ("[{0}] {1}", logTag, message);

			if (debug || overrideDebug) Debug.LogWarning (_message);
		}

		/// <summary>
		/// Logs a formatted warning message to Unity Console.
		/// </summary>
		protected void LogWarningFormat (string format, params object[] args)
		{
			string _format = string.Format ("[{0}] ", logTag) + format;

			if (debug) Debug.LogWarningFormat (_format, args);
		}

		/// <summary>
		/// Logs a error message to Unity Console.
		/// </summary>
		protected void LogError (object message, bool overrideDebug = false)
		{
			string _message = string.Format ("[{0}] {1}", logTag, message);

			if (debug || overrideDebug) Debug.LogError (_message);
		}

		/// <summary>
		/// Logs a formatted error message to Unity Console.
		/// </summary>
		protected void LogErrorFormat (string format, params object[] args)
		{
			string _format = string.Format ("[{0}] ", logTag) + format;

			if (debug) Debug.LogErrorFormat (_format, args);
		}

		#endregion
	}

}