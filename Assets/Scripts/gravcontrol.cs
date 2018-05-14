using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gravcontrol : MonoBehaviour {
	// Use this for initialization


	void Start ()
    {
        if(Physics2D.gravity.y > 0)
        {
            Physics2D.gravity = Physics2D.gravity * -1;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetButtonDown("Fire1"))
		{
			//Physics2D.gravity = new Vector3(0,55.0f,0f);
			Physics2D.gravity = Physics2D.gravity * -1;
		}
	}
}
