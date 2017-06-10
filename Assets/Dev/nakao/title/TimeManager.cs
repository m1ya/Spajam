﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : SingletonMonoBehaviour<TimeManager> {

	[SerializeField]
	static float timeLimit = 60;
	float time = timeLimit;

	// Update is called once per frame
	void Update () {
		if (GameManager.isPlaying) {
			if (time > 0) CountDown ();
			if (time < 0) Stop ();
		}
	}

	void Stop(){
		time = 0.0f;
		GameManager.GameEnd (0);
	}
		

	void CountDown(){
	    time -= Time.deltaTime;
	}

}