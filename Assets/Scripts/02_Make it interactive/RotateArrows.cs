using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArrows : MonoBehaviour {

	bool rotatingObject = true;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(rotatingObject)
			RotateCurrentObject ();
	}

	void RotateCurrentObject(){
		// Adds one degree of rotation to y axis every frame
		transform.Rotate (new Vector3 (0,0,-0.5f));
	}

	public void ToggleRotation(){
		rotatingObject = !rotatingObject;
	}
}
