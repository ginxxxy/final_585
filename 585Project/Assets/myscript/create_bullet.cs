using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class create_bullet : MonoBehaviour {
	public GameObject bullet;
	public GameObject cam;
	public GameObject wand01;
	public GameObject wand02;
	public GameObject wand03;
	public GameObject wand04;
	public GameObject bullet01;
	public GameObject bullet02;
	public GameObject bullet03;
	public GameObject bullet04;
	public Text bulletText;

	private int wand01_N;
	private int wand02_N;
	private int wand03_N;
	private int wand04_N;
	// Use this for initialization
	void Start () {
		wand01_N = 17;
		wand02_N = 15;
		wand03_N = 13;
		wand04_N = 10;
	}

	void Update(){
		if (wand01 != null && wand01.activeSelf == true) {
			bulletText.text = "Bullet: " + wand01_N;
		}  else if (wand02 != null && wand02.activeSelf == true) {
			bulletText.text = "Bullet: " + wand02_N;
		}  else if (wand03 != null && wand03.activeSelf == true) {
			bulletText.text = "Bullet: " + wand03_N;
		}  else if (wand04 != null && wand04.activeSelf == true) {
			bulletText.text = "Bullet: " + wand04_N;
		}

	}
	
	// Update is called once per frame
	public void onClick () {
		if (wand01.activeSelf == true && wand01_N > 0) {
			Destroy (Instantiate (bullet01, cam.transform.position, cam.transform.rotation), 5f);
			wand01_N--;
		}
		if (wand02.activeSelf == true && wand02_N > 0) {
			Destroy (Instantiate (bullet02, cam.transform.position, cam.transform.rotation), 5f);
			wand02_N--;
		}
		if (wand03.activeSelf == true && wand03_N > 0) {
			Destroy (Instantiate (bullet03, cam.transform.position, cam.transform.rotation), 5f);
			wand03_N--;
		}
		if (wand04.activeSelf == true && wand04_N > 0) {
			Destroy (Instantiate (bullet04, cam.transform.position, cam.transform.rotation), 5f);
			wand04_N--;
		}
	}
}
                         