using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text text = this.GetComponent<Text> ();
		text.text = TimeManager.Instance.GetTime ().ToString("f2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
