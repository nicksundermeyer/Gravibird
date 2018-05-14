using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour {
	public AudioSource AS;

	public void Start () {
		AS.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
