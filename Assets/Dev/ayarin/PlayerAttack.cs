using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Linq;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour {

	[SerializeField]
	private SpeechMessage speechMessage;
	[SerializeField] GameObject worldPanel;
	[SerializeField] GameObject hazeroPrefab;
	[SerializeField] GameObject sunderPrefab;
	[SerializeField] GameObject meteoPrefab;
	[SerializeField] GameObject spherePrefab;
	private bool worldFlag = true, hazeroFlag = true, sunderFlag = true, meteoFlag = true;
	private float worldCoolTime = 3, hazeroCoolTime = 3, sunderCoolTime = 3, meteoCoolTime = 3;
	GameObject ins;
	AttackUIManager attackUIManager;

	// Use this for initialization
	void Start () {
		attackUIManager = this.gameObject.GetComponent<AttackUIManager> ();
		speechMessage.OnSpeechChanged.Subscribe(message =>
			{
				Attack(message);
			});
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Attack(string mes){
		if (Words.hazero.Count (message => message == mes) > 0 && hazeroFlag) {
			Debug.Log("hazero");
			hazeroFlag = false;
			AudioManager.Instance.PlaySE("magic-ice2");
			ins = Instantiate (hazeroPrefab, transform.position, Quaternion.identity);
			ins.GetComponent<EffectSettings> ().Target = this.transform.GetChild(0).gameObject;
			ins = Instantiate (spherePrefab, transform.position, Quaternion.identity);
			ins.GetComponent<MoveSphere> ().targetPosition = this.transform.GetChild (0).gameObject.transform.position;
			StartCoroutine(Wait("hazero"));
		}
		if (Words.sunder.Count (message => message == mes) > 0 && sunderFlag) {
			Debug.Log("sunder");
			sunderFlag = false;
			AudioManager.Instance.PlaySE("magic-electron4");
			ins = Instantiate (sunderPrefab, transform.position, Quaternion.identity);
			ins.GetComponent<EffectSettings> ().Target = this.transform.GetChild(0).gameObject;
			ins = Instantiate (spherePrefab, transform.position, Quaternion.identity);
			ins.GetComponent<MoveSphere> ().targetPosition = this.transform.GetChild (0).gameObject.transform.position;
			StartCoroutine(Wait("sunder"));
		}
		if (Words.meteo.Count (message => message == mes) > 0 && meteoFlag) {
			Debug.Log("meteo");
			meteoFlag = false;
			AudioManager.Instance.PlaySE("magic-flame2");
			ins = Instantiate (meteoPrefab, transform.position, Quaternion.identity);
			ins.GetComponent<EffectSettings> ().Target = this.transform.GetChild(0).gameObject;
			ins = Instantiate (spherePrefab, transform.position, Quaternion.identity);
			ins.GetComponent<MoveSphere> ().targetPosition = this.transform.GetChild (0).gameObject.transform.position;
			StartCoroutine(Wait("meteo"));
		}
		if (Words.world.Count (message => message == mes) > 0 && worldFlag) {
			Debug.Log("world");
			worldFlag = false;
			AudioManager.Instance.PlaySE("nc150248");
			TimeManager.Instance.SetSlow ();
			worldPanel.SetActive (true);
			StartCoroutine(Wait("world"));
			Invoke ("worldFunc",5f);
		}
	}

	void worldFunc(){
		worldPanel.SetActive (false);
	}

	IEnumerator Wait(string type) {
		attackUIManager.RecastSkill (type);
		if (type == "world") {
			yield return new WaitForSeconds (worldCoolTime);
			worldFlag = true;
		}else if (type == "hazero") {
			yield return new WaitForSeconds (hazeroCoolTime);
			hazeroFlag = true;
		}else if (type == "sunder") {
			yield return new WaitForSeconds (sunderCoolTime);
			sunderFlag = true;
		}else if (type == "meteo") {
			yield return new WaitForSeconds (meteoCoolTime);
			meteoFlag = true;
		}
	}

}
