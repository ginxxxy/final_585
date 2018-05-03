using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene (6);
	}

	public void OpenMenu(){
		SceneManager.LoadScene (0);
	}

	public void QuitGame(){
		Debug.Log ("Quit!");
		Application.Quit ();
	}

	public void level1(){
		SceneManager.LoadScene (1);
	}

	public void level2(){
		SceneManager.LoadScene (2);
	}
	public void level3(){
		SceneManager.LoadScene (3);
	}
	public void level4(){
		SceneManager.LoadScene (4);
	}
	public void level5(){
		SceneManager.LoadScene (5);
	}


}
