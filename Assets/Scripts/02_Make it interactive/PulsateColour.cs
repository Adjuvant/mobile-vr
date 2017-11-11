using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsateColour : MonoBehaviour
{
	Material mat;
	private float _endRange = 1;
	private float _startRange = 0.5f;
	private float _oscillateRange;
	private float _oscillateOffset;
	public float f = 0.35f;
	// Use this for initialization
	void Start ()
	{
		mat = GetComponent<Renderer> ().material;	
		_oscillateRange = (_endRange - _startRange) / 2;
		_oscillateOffset = _oscillateRange + _startRange;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Color c = mat.color;
		c.r = _oscillateOffset + Mathf.Sin (Time.time * f) * _oscillateRange;
		mat.color = c;
	}
}
