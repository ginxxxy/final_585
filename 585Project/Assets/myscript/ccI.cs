using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccI : MonoBehaviour {

	public GameObject coinsI;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mI") != null) {
			if (coinsI.activeSelf == true) {

				Destroy (coinsI);
				Scorecount.scorevalue++;

			}
		}
	}
}
