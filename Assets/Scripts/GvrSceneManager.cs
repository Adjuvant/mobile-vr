// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

// Ensures correct app and scene setup.
public class GvrSceneManager : MonoBehaviour
{
	public GameObject m_launchVrHomeButton;
	private Vector3 startingPosition;

	void Start ()
	{
		Input.backButtonLeavesApp = true;
		startingPosition = transform.localPosition;

		#if !UNITY_ANDROID || UNITY_EDITOR
		if (m_launchVrHomeButton == null) {
			return;
		}
		m_launchVrHomeButton.SetActive(false);
		#else
		GvrDaydreamApi.CreateAsync((success) => {
		if (!success) {
		// Unexpected. See GvrDaydreamApi log messages for details.
		Debug.LogError("GvrDaydreamApi.CreateAsync() failed");
		}
		});
		#endif  // !UNITY_ANDROID || UNITY_EDITOR
	}

	void Update ()
	{
		// Exit when (X) is tapped.
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void Reset ()
	{
		transform.localPosition = startingPosition;
	}

	public void Recenter ()
	{
		#if !UNITY_EDITOR
		GvrCardboardHelpers.Recenter();
		#else
		GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator> ();
		if (emulator == null) {
			return;
		}
		emulator.Recenter ();
		#endif  // !UNITY_EDITOR
	}

	public void LaunchVrHome() {
		#if UNITY_ANDROID && !UNITY_EDITOR
		GvrDaydreamApi.LaunchVrHomeAsync((success) => {
		if (!success) {
		// Unexpected. See GvrDaydreamApi log messages for details.
		Debug.LogError("GvrDaydreamApi.LaunchVrHomeAsync() failed");
		}
		});
		#endif  // UNITY_ANDROID && !UNITY_EDITOR
	}
}
