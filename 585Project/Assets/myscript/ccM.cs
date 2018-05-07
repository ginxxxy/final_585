using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccM : MonoBehaviour {

	public GameObject coinsM;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mM") != null) {
			if (coinsM.activeSelf == true) {

				Destroy (coinsM);
				Scorecount.scorevalue++;

			}
		}
	}
}
