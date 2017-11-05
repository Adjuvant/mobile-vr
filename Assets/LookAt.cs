using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LookAt : MonoBehaviour {
    public Transform _this;
	// Use this for initialization
	void Start () {
		transform.LookAt(_this,Vector3.up);
	}
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        transform.LookAt(_this,Vector3.up);
    }
}
