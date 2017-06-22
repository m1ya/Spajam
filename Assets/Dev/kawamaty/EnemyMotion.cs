using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour {
	static float timeLimit = 60;
	float time = timeLimit;


	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update (){
		CountDown ();
		Debug.Log (time);


		if (Input.GetKey (KeyCode.UpArrow)) {
			anim.SetBool ("skill_1", true);
		} else {
			anim.SetBool ("skill_1", false);
		}

	}

	void CountDown(){
		bool slow = false;

		if (Input.GetKey (KeyCode.DownArrow)) {
			slow = true;
		} else {
			slow = false;
		}  


		if (slow == true) {
			Time.timeScale = 0.5f;
			time -= Time.deltaTime / 2;
		} else {
			Time.timeScale = 1;
			time -= Time.deltaTime;
		}
	}

/************************************************
PlayerAttack.csでTimeManager.csのSetSlow()がInstanceされて
slow = trueになった時　時間と敵の速度を1/2にしたい

ここでは↓が押されているあいだだけにslowをtrueにして時間とアニメーションの時間の速度を半分にした
Debug.Log (time);で時間を確認している。
*************************************************/


/*	void CountDown(){
		if (TimeManager.slow = true) {
			Time.timeScale = 0.5f;
			time -= Time.deltaTime / 2;
		} else {
			Time.timeScale = 1;
			time -= Time.deltaTime;
		}
	}
	*/


}
