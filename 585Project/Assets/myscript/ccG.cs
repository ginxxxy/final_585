using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccG : MonoBehaviour {

	public GameObject coinsG;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mG") != null) {
			if (coinsG.activeSelf == true) {

				Destroy (coinsG);
				Scorecount.scorevalue++;

			}
		}
	}
}
