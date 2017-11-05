using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger : MonoBehaviour {

	[SerializeField]
	List<GameObject> objet_d_art;

	[SerializeField]
	GameObject anchor;

	public GameObject currentObject;

	int indexOfObject;

	// Use this for initialization
	void Start () {
		SetObject (0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			ChangeObject ();
		}
	}

	void SetObject (int value)
	{
		// Safety boolean check
		if(currentObject)
			currentObject.SetActive (false);
		
		indexOfObject = value;
		currentObject = objet_d_art [indexOfObject];
		currentObject.SetActive (true);
	}

	public void ChangeObject(){
		int l = objet_d_art.Count;
		if (indexOfObject + 1 >= l)
			SetObject (0);
		else
			SetObject (indexOfObject + 1);
	}
}
