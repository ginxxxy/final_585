using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccT : MonoBehaviour {

	public GameObject coinsT;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mT") != null) {
			if (coinsT.activeSelf == true) {

				Destroy (coinsT);
				Scorecount.scorevalue++;

			}
		}
	}
}
