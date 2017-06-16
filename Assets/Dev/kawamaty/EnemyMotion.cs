using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour {

	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update ()
	{
		if (Input.GetKey ("up")) {
			anim.SetBool ("skill_1", true);
		} else {
			anim.SetBool ("skill_1", false);
		}
	}
}
