using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccP : MonoBehaviour {

	public GameObject coinsP;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mP") != null) {
			if (coinsP.activeSelf == true) {

				Destroy (coinsP);
				Scorecount.scorevalue++;

			}
		}
	}
}
