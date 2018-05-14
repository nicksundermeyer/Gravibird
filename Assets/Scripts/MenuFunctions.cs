using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour {
	public GameObject Overlay;
	public AudioSource Audio;

	public void PauseGame () {
		Debug.Log ("paused");
		Overlay.SetActive (true);
		Time.timeScale = 0;

	}

	public void ResumeGame () {
		Debug.Log ("resumed");
		Overlay.SetActive (false);
		SceneManager.LoadScene ("scene1");

		//Audio.Play ();
	}

	public void QuitGame () {
		SceneManager.LoadScene ("menu");
		Audio.Play ();
	}
	public void LoadScene1() {
		SceneManager.LoadScene ("scene1");
		Time.timeScale = 1;
		//Audio.Play ();
	}

	public void ExitGame () {
		Application.Quit ();
	}
	public void AboutGame () {
		Overlay.SetActive (true);
		Audio.Play ();
	}
	public void CloseOverlay () {
		Overlay.SetActive (false);
		Audio.Play ();
	}
}