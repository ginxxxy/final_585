using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour {
	public int wand_power;
	private Text popup;

	int score = 0;

	void Start () {
		popup = GameObject.Find ("HitAlert").GetComponent<Text>();
		popup.enabled = false;
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Cube"){
			StartCoroutine(ShowMessage("You hit it!!!", 2));
			//Debug.Log ("hp before: " + cubeHP.cube_hp);
			cubeHP.cube_hp -= wand_power;
			//Debug.Log ("hp after: " + cubeHP.cube_hp);
			gameObject.SetActive (false);

			if (cubeHP.cube_hp <= 0) {
				col.gameObject.SetActive(false);
				score++;
				cubeHP.resetHp ();
			}
		}

	}

	IEnumerator ShowMessage (string message, float delay) {
		popup.text = message;
		popup.enabled = true;
		yield return new WaitForSeconds(delay);
		popup.enabled = !popup.enabled;
	}


}
