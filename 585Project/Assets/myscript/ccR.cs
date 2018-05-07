using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccR : MonoBehaviour {

	public GameObject coinsR;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mR") != null) {
			if (coinsR.activeSelf == true) {

				Destroy (coinsR);
				Scorecount.scorevalue++;

			}
		}
	}
}
