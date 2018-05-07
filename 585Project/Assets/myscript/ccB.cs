using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccB : MonoBehaviour {

	// Use this for initialization
	public GameObject coinsB;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mB") != null) {
			if (coinsB.activeSelf == true) {

				Destroy (coinsB);
				Scorecount.scorevalue++;

			}
		}
	}
}
