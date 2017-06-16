using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {
	public void Awake(){
		//AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber40");
	}

	void Start() {
		AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber40");
	}


	void Update(){
		//AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber40");
	}

	public void ButtonStart(){
		MySceneManager.Instance.GoToStageSelect();
		//AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber40");
		/*************************************************
		 * 1回しか音が出ないのはStartでしか指示していないから？　
		 * 音声認識でBGMを消したら復活できないのでは？
		 * 2行目を試しに追加
		 * でもpcでプレイすると音声が流れる。
		 * スマホでプレイした時だけBGMが消える
		 * pcで音が流れるのはpcの時は音声機能がつかえないからか
		 * ということは音声機能が悪さをしているか、音声機能でBGMが止まって再開できていないか
		 * 2行目は意味なかった
		 * スクリプトからBGMを流すんじゃなくてシーンにオーディオソースつければ3分で解決する。でもSEは解決しない
		 *************************************************/

	}
}
