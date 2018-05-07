using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccE : MonoBehaviour {

	// Use this for initialization
	public GameObject coinsE;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mE") != null) {
			if (coinsE.activeSelf == true) {

				Destroy (coinsE);
				Scorecount.scorevalue++;

			}
		}
	}
}
