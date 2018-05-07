using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccQ : MonoBehaviour {

	public GameObject coinsQ;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mQ") != null) {
			if (coinsQ.activeSelf == true) {

				Destroy (coinsQ);
				Scorecount.scorevalue++;

			}
		}
	}
}
