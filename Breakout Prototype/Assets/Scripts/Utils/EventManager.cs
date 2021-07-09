using System;
using System.Collections.Generic;
using UnityEngine;

namespace JustKrated.Utils
{
	public static class EventManager
	{
		private static Dictionary<string, Action> eventDictionary = new Dictionary<string, Action> ();

		private static Dictionary<string, object> dataStorage = new Dictionary<string, object> ();

		#region * LISTENERS *

		/// <summary>
		/// Adds listener to an event with the given name.
		/// </summary>
		/// <param name="eventName">The name of the event.</param>
		/// <param name="listener">THe action to be listened.</param>
		public static void AddListener (string eventName, Action listener)
		{
			if (eventDictionary.TryGetValue (eventName, out Action thisEvent))
			{
				//Adds listener to the existing event
				thisEvent += listener;
				//Updates the Dictionary
				eventDictionary[eventName] = thisEvent;

			}
			else
			{
				//Adds listener to the existing event
				thisEvent += listener;
				//Adds event to the Dictionary for the first time
				eventDictionary.Add (eventName, thisEvent);
			}
		}

		/// <summary>
		/// Removes listener to the event with the given name.
		/// </summary>
		/// <param name="eventName">The name of the event.</param>
		/// <param name="listener">The action to be removed.</param>
		public static void RemoveListener (string eventName, Action listener)
		{
			if (eventDictionary.TryGetValue (eventName, out Action thisEvent))
			{
				//Removes listener from the existing event
				thisEvent -= listener;
				//Updates the Dictionary
				eventDictionary[eventName] = thisEvent;

				//If event is null remove it from the Dictionary
				if (thisEvent == null)
				{
					//Debug.LogWarningFormat ("{0} Event is NULL. Removing...", eventName);
					eventDictionary.Remove (eventName);
				}
			}
			else
			{
				Debug.LogWarningFormat ("Event Manager: '{0}' event does not exist. Make sure it is not being removed before time or not being created.", eventName);
			}
		}

		/// <summary>
		/// Triggers event with given name.
		/// </summary>
		/// <param name="eventName">The name of the event to be called.</param>
		public static void TriggerEvent (string eventName)
		{
			if (eventDictionary.TryGetValue (eventName, out Action thisEvent))
			{
				if (thisEvent != null)
					thisEvent.Invoke ();
				else
				{
					Debug.LogWarningFormat ("Event Manager: '{0}' event is NULL. At least 1 listener is required.", eventName);
				}
			}
			//else
			//{
			//	Debug.LogWarningFormat ("Event Manager: '{0}' event does not exist. Make sure it is not being removed before time or not being created.", eventName);
			//}
		}

		#endregion

		#region * DATA *

		/// <summary>
		/// Save data for a event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <param name="data">Object to be stored.</param>
		public static void SetData (string eventName, object data)
		{
			if (dataStorage.ContainsKey (eventName))
				dataStorage[eventName] = data;
			else
				dataStorage.Add (eventName, data);
		}

		/// <summary>
		/// Return the Object data for an event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <returns>The stored object. <c>Null</c> if nothing found.</returns>
		public static object GetData (string eventName)
		{
			try
			{
				if (dataStorage.ContainsKey (eventName))
					return dataStorage[eventName];
				else return null;
			}
			catch (Exception e)
			{
				Debug.LogWarning ("Event Manager: " + e.Message);
				return null;
			}
		}

		/// <summary>
		/// Removes the stored data for an event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		public static void RemoveData (string eventName)
		{
			try
			{
				dataStorage.Remove (eventName);
			}
			catch (Exception)
			{
				Debug.LogWarningFormat ("Event Manager: '{0}' event does not exist. Make sure it is not being removed before time or not being created.", eventName);
			}
		}

		/// <summary>
		/// Triggers an event when new data is send.
		/// </summary>
		/// <param name="eventName">Name of the event to be triggered.</param>
		/// <param name="data">Object to be stored.</param>
		public static void TriggerDataChange (string eventName, object data)
		{
			SetData (eventName, data);

			TriggerEvent (eventName);
		}


		/// <summary>
		/// Clears all stored data from events.
		/// </summary>
		public static void ClearDataStorage ()
		{
			dataStorage.Clear ();
		}

		public static void AddInt (string eventName, int value)
		{
			int i = GetInt (eventName);

			SetData (eventName, i + value);
		}

		/// <summary>
		/// Return the integer data for the event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <returns>The stored integer.</returns>
		public static int GetInt (string eventName)
		{
			try
			{
				if (dataStorage.ContainsKey (eventName))
					return (int)dataStorage[eventName];
				else
					return 0;
			}
			catch (Exception e)
			{
				Debug.LogWarning ("Event Manager: " + e.Message);
				return 0;
			}
		}

		/// <summary>
		/// Return the string data for the event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <returns>The stored string.</returns>
		public static string GetString (string eventName)
		{
			try
			{
				if (dataStorage.ContainsKey (eventName))
					return (string)dataStorage[eventName];
				else
					return "";
			}
			catch (Exception e)
			{
				Debug.LogWarning ("Event Manager: " + e.Message);
				return "";
			}
		}

		/// <summary>
		/// Return the bool data for the event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <returns>The stored bool.</returns>
		public static bool GetBool (string eventName)
		{
			try
			{
				if (dataStorage.ContainsKey (eventName))
					return (bool)dataStorage[eventName];
				else
					return false;
			}
			catch (Exception e)
			{
				Debug.LogWarning ("Event Manager: " + e.Message);
				return false;
			}
		}

		/// <summary>
		/// Return the float data for the event with a given name.
		/// </summary>
		/// <param name="eventName">Name of the event.</param>
		/// <returns>The stored float.</returns>
		public static float GetFloat (string eventName)
		{
			try
			{
				if (dataStorage.ContainsKey (eventName))
					return (float)dataStorage[eventName];
				else
					return 0;
			}
			catch (Exception e)
			{
				Debug.LogWarning ("Event Manager: " + e.Message);
				return 0;
			}
		}

		#endregion
	}
}