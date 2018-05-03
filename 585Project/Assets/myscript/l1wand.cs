using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l1wand : MonoBehaviour {
	public GameObject wand01;
	public GameObject wand02;
	public GameObject wand03;
	public GameObject wand04;
	// Use this for initialization
	void Start () {
		wand01.SetActive(true) ;
		wand02.SetActive(false);
		wand03.SetActive(false);
		wand04.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
