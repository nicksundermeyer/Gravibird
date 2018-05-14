using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour {
	private SpriteRenderer SR;
	public GameObject player;
	public AudioSource jumpSound;

	void Start () {
		SR = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.Space))
        {
			jumpSound.Play ();
			//SR.flipY = !SR.flipY;
			//this.gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *-1, transform.localScale.z);
			//player.gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *-1, transform.localScale.z);

			Vector3 theScale = transform.localScale;
			theScale.y *= -1;
			transform.localScale = theScale;
        }
    }
}
