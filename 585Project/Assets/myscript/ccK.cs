﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccK : MonoBehaviour {

	// Use this for initialization
	public GameObject coinsK;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onClick(){
		if (GameObject.Find ("mK") != null) {
			if (coinsK.activeSelf == true) {

				Destroy (coinsK);
				Scorecount.scorevalue++;

			}
		}
	}
}
