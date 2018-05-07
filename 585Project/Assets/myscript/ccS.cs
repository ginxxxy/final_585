using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccS : MonoBehaviour {

	public GameObject coinsS;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mS") != null) {
			if (coinsS.activeSelf == true) {

				Destroy (coinsS);
				Scorecount.scorevalue++;

			}
		}
	}
}
