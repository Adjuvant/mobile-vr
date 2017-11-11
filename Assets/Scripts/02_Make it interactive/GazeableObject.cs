using UnityEngine;
using System.Collections;

// Using "Inheritance" to share some common behaviours
[RequireComponent(typeof(Collider))]
public class GazeableObject : MonoBehaviour {

	public virtual void  Start() {
		SetGazedAt(false);
	}

	public virtual void SetGazedAt(bool gazedAt) {		
	}
}