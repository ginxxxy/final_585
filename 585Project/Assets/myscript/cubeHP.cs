using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeHP : MonoBehaviour {
	public static int cube_hp;

	// Use this for initialization
	void Start () {
		resetHp ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<MeshRenderer> () != null) {
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
		}
	}

	public static void resetHp(){
		switch (SceneManager.GetActiveScene().name) {
		case "level1":
			cube_hp = 1;
			break;
		case "level2":
			cube_hp = 2;
			break;
		case "level3":
			cube_hp = 3;
			break;
		case "level4":
			cube_hp = 4;
			break;
		case "level5":
			cube_hp = 5;
			break;
		}
	}
}
