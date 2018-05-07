using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccO : MonoBehaviour {

	public GameObject coinsO;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mO") != null) {
			if (coinsO.activeSelf == true) {

				Destroy (coinsO);
				Scorecount.scorevalue++;

			}
		}
	}
}
