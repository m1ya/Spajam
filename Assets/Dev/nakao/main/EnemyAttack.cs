using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
	public float count;
	public bool standby = false;
	// Use this for initialization
	private Animator anim;
	void Start () {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		Roop ();
		/*if (count >= 1 && !standby) AttackSmall ();
		if (count >= 3) AttackBig ();*/
		if(count < 3){
			anim.SetBool ("skill_1", false);
		}
		if (count >= 3) {
			anim.SetBool ("skill_1", true);
			AttackBig ();

		}
	

	}
	//
	//anim.SetBool ("skill_1", false);

	void Roop(){
		count += Time.deltaTime * 1;
	}

	void AttackSmall(){
		Instantiate(ParticleManager.Instance.Create("EnergyExplosionMobile"), transform.position, Quaternion.identity);
		//count = 0;
		standby = true;
		Debug.Log ("スモール");
	}
	void AttackBig(){
		//Instantiate(ParticleManager.Instance.Create("FrostBombMobile"), transform.position, Quaternion.identity);
		Instantiate(ParticleManager.Instance.Create("FrostBombMobile"), new Vector3(0, 300, 0), Quaternion.identity);
	
		count = 0;
		standby = false;
		Debug.Log ("ビッグ");

	}
}


