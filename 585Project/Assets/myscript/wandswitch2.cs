using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wandswitch2 : MonoBehaviour {

	// Use this for initialization
	public GameObject wand1;
	public GameObject wand2;
	private int index = 1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void onClick(){
		if (index < 2) {
			index++;
		}  else {
			index = 1;
		}
		if (index == 1) {
			wand1.SetActive (true);
			wand2.SetActive (false);
		}
		if (index == 2) {
			wand2.SetActive (true);
			wand1.SetActive (false);
		}


	}
}
