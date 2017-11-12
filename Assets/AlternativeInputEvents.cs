using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AlternativeInputEvents : MonoBehaviour {
	public GameObject effectedCube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Toggle(){
		effectedCube.transform.DOFlip ();
		effectedCube.transform.DOShakePosition (0.2f);
		effectedCube.transform.DOShakeRotation (0.2f);
	}
}
