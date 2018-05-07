using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccL : MonoBehaviour {

	public GameObject coinsL;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mL") != null) {
			if (coinsL.activeSelf == true) {

				Destroy (coinsL);
				Scorecount.scorevalue++;

			}
		}
	}
}
