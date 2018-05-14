using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour
{
    public float maxSpeed = 30;
    public int acceleration = 70;
    public Rigidbody2D rb;

	public AudioSource deathSound;
	public AudioSource music;

	public ParticleSystem PS;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(40, rb.velocity.y);
    }

    private void FixedUpdate()
    {
		Debug.Log(rb.velocity.x);
        rb.AddForce(new Vector2(acceleration -((1/maxSpeed) * Mathf.Pow(rb.velocity.x, 2)), 0)); // acceleration up to max speed

        // if the player gets into the final 1/8 of the screen, slow them down to keep them on the screen
        if (Camera.main.WorldToScreenPoint(rb.position).x > (Screen.width - (Screen.width / 6)))
        {
            rb.AddForce(new Vector2(-acceleration, 0));
        }
    }

	private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Enemy")
        {
			rb.AddForce (new Vector2 (0, 0));
			PS.Play ();
			deathSound.Play ();
			music.pitch = 0.5f;
			music.volume = 0.5f;
			Time.timeScale = 0.1f;
			yield return new WaitForSeconds (0.3f);
			Time.timeScale = 1f;
			music.pitch = 1.4f;
			music.volume = 1.0f;
		//	wait ();
		//	System.Threading.Thread.Sleep(2000);
			LoadScene ();
        }
    }

	/*IEnumerator wait () {

		yield return new WaitForSeconds (1);
		LoadScene ();
	}*/

	private void LoadScene() {
		SceneManager.LoadScene("scene1"); // loads current scene

	}
}
