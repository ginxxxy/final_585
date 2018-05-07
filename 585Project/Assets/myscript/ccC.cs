using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccC : MonoBehaviour {

	public GameObject coinsC;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mC") != null) {
			if (coinsC.activeSelf == true) {

				Destroy (coinsC);
				Scorecount.scorevalue++;

			}
		}
	}
}
