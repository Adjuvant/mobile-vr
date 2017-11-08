using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SelectTween : MonoBehaviour {
	public float tweenDuration = 0.2f;
	public float tweenStrength = 0.1f;
	public void Selected(){
		gameObject.transform.DOShakeScale (tweenDuration,tweenStrength);
	}
}
