using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccF : MonoBehaviour {

	public GameObject coinsF;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mF") != null) {
			if (coinsF.activeSelf == true) {

				Destroy (coinsF);
				Scorecount.scorevalue++;

			}
		}
	}
}
