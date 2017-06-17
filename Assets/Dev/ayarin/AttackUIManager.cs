using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AttackUIManager : MonoBehaviour {

	public Image worldImage, hazeroImage, thunderImage, meteoImage;
	float hideXPos = -600, XPos = 110;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RecastSkill(string type){
		if(type == "world"){
			worldImage.transform.DOMoveX (hideXPos, 0.1f);
			worldImage.transform.DOMoveX (XPos, 2.9f);
		}else if(type == "hazero"){
			hazeroImage.transform.DOMoveX (hideXPos, 0.1f);
			hazeroImage.transform.DOMoveX (XPos, 2.9f);
		}else if(type == "sunder"){
			thunderImage.transform.DOMoveX (hideXPos, 0.1f);
			thunderImage.transform.DOMoveX (XPos, 2.9f);
		}else if(type == "meteo"){
			meteoImage.transform.DOMoveX (hideXPos, 0.1f);
			meteoImage.transform.DOMoveX (XPos, 2.9f);
		}
	}
}
