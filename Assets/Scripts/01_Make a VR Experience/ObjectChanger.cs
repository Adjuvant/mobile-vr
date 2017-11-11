using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger : MonoBehaviour {

	// The objects you want to display are held in a List object
	// that you can  access in theinspector using the 
	// [SerializeField] attribute
	[SerializeField]
	List<GameObject> objet_d_art;

	// Reference to currently displayed object
	public GameObject currentObject;

	int indexOfObject;

	// Use this for initialization
	void Start () {
		SetObject (0);
	}
	
	// Update is called once per frame
	void Update () {
		// Simple way to test functionality in the preview mode.
		if (Input.GetKeyDown (KeyCode.P)) {
			ChangeObject ();
		}
	}

	// Method to change the currently displayed object
	// By turning on or off the GameObjects
	void SetObject (int value)
	{
		// Safety boolean check
		if(currentObject)
			currentObject.SetActive (false);
		
		indexOfObject = value;
		currentObject = objet_d_art [indexOfObject];
		currentObject.SetActive (true);
	}

	// Method to tell the script to do stuff,
	// Triggered by the event system by plumbing in events
	// or direct references from other scripts.
	public void ChangeObject(){
		int l = objet_d_art.Count;
		if (indexOfObject + 1 >= l)
			SetObject (0);
		else
			SetObject (indexOfObject + 1);
	}
}
