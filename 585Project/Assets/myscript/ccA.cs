using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccA : MonoBehaviour {
	public GameObject coinsA;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick(){
		if (GameObject.Find ("mA") != null) {
			if (coinsA.activeSelf == true) {

				Destroy (coinsA);
				Scorecount.scorevalue++;

			}
		}
	}
}
