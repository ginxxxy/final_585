using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccN : MonoBehaviour {

	public GameObject coinsN;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mN") != null) {
			if (coinsN.activeSelf == true) {

				Destroy (coinsN);
				Scorecount.scorevalue++;

			}
		}
	}
}
