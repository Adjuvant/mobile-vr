using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	bool rotatingCurrentObject = false;
	ObjectChanger holder;
	// Use this for initialization
	void Start () {
		holder = gameObject.GetComponent<ObjectChanger> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			rotatingCurrentObject = !rotatingCurrentObject;
		}

		if(rotatingCurrentObject)
			RotateCurrentObject ();
	}

	void RotateCurrentObject(){
		// Adds one degree of rotation to y axis every frame
		holder.currentObject.transform.Rotate (new Vector3 (0,1,0));
	}

	public void ToggleRotation(){
		rotatingCurrentObject = !rotatingCurrentObject;
	}
}
