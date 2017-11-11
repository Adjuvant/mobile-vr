using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimedInputObject : MonoBehaviour, ITimedInputHandler {
	public UnityEvent yourCustomEvent;

	#region ITimedInputHandler implementation
	public void HandleTimedInput ()
	{
		yourCustomEvent.Invoke();
		Debug.Log (gameObject.name + ": Triggered");
	}
	#endregion
}
