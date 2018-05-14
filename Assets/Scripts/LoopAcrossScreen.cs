using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAcrossScreen: MonoBehaviour {

    public bool block = true;

    private float initialYBackground;
    private float leftX;
    private float rightX;

    private void Start()
    {
        initialYBackground = Camera.main.WorldToScreenPoint(transform.position).y;
        leftX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        rightX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    }
	
	// Update is called once per frame
	void Update ()
    {

        if(block)
        {
            if (Camera.main.WorldToScreenPoint(transform.position).x < 0)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(Screen.width, 4*Screen.width), Random.Range(Screen.height/3, Screen.height-Screen.height/3)));
            }
        }
        else
        {
            if (Camera.main.WorldToScreenPoint(transform.position).x < 0)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector2(transform.position.x+568, initialYBackground));
            }
        }
	}
}
