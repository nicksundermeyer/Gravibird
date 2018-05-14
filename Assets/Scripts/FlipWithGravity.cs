using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipWithGravity : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetButtonDown("Fire1"))
        {
            Vector3 theScale = transform.localScale;
            theScale.y *= -1;
            transform.localScale = theScale;
        }
    }
}
