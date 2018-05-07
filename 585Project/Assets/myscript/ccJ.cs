using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccJ : MonoBehaviour {

	public GameObject coinsJ;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mJ") != null) {
			if (coinsJ.activeSelf == true) {

				Destroy (coinsJ);
				Scorecount.scorevalue++;

			}
		}
	}
}
