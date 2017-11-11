using UnityEngine;
using System.Collections;

public class GazeableObjectMenu : GazeableObject {

	[SerializeField]
	GameObject menu;

	bool menuActive = true;

	public override void  Start() {
		base.Start ();
	}

	public override void SetGazedAt(bool gazedAt) {
		menuActive = !menuActive;
		menu.SetActive (menuActive);
	}
}