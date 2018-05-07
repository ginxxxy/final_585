using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccH : MonoBehaviour {

	public GameObject coinsH;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mH") != null) {
			if (coinsH.activeSelf == true) {

				Destroy (coinsH);
				Scorecount.scorevalue++;

			}
		}
	}
}
