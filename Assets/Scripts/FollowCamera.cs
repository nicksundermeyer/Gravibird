using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/10 + 40, Screen.height/2));
	}
}
