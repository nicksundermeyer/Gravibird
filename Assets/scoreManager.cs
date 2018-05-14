using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;

	public AudioSource AS;

	public float score;
	public float highScore;

	public float PPS;

	public bool scoreIncrease;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat("Highscore") != null) {
			highScore = PlayerPrefs.GetFloat ("Highscore");
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreIncrease) {
			score += PPS * Time.deltaTime;
		}

		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetFloat ("Highscore", highScore);
			AS.Play ();
		}

		scoreText.text = "Score (meters): " + score;
		highScoreText.text = "Best: " + Mathf.Round (highScore);
	}
}
