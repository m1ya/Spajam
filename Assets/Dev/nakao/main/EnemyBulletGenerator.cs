﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour {

	public GameObject bullet;
	float c;
	//仮で3秒ごとに出している
	void Update () {
		c += Time.deltaTime * 1;
		if (c >= 3) {
			Generate ();
			c = 0;
		}
	}

	public void Generate(){
		Instantiate (bullet, this.transform.position, Quaternion.identity);


		//transform.position = new Vector3(0, 500, 0);
		//Instantiate (bullet, new Vector3(0, 0, 500), Quaternion.identity);
	}
}
