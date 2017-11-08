using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectChanger : MonoBehaviour {

	[SerializeField]
	float objectChangeTime = 5f;
	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {
		// Start function WaitAndError as a coroutine.
		coroutine = WaitAndChange(objectChangeTime);
		StartCoroutine(coroutine);
	}

	private IEnumerator WaitAndChange(float waitTime)
	{		
		while (true) {
			yield return new WaitForSeconds (waitTime);
			if(gameObject.GetComponent<ObjectChanger> ())
				gameObject.GetComponent<ObjectChanger> ().ChangeObject ();
		}
	}
}
