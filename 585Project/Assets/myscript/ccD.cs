using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccD : MonoBehaviour {

	// Use this for initialization
	public GameObject coinsD;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mD") != null) {
			if (coinsD.activeSelf == true) {

				Destroy (coinsD);
				Scorecount.scorevalue++;

			}
		}
	}
}
