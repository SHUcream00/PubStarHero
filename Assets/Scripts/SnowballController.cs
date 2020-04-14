using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballController : MonoBehaviour {

    public float speedmag = 20f;
    private float speedx = 20f;
    private float speedy = 0f;
	public float delay = 0.00001f;
    public Transform Effect;
    private Rigidbody2D ball;

	public PlayerController thePlayer;

    // Use this for initialization
    void Start () {
        ball = GetComponent<Rigidbody2D>();
		thePlayer = FindObjectOfType<PlayerController>();
		Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(),thePlayer.GetComponent<Collider2D>(), true);
		Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(),ball.GetComponent<Collider2D>(), true);


        // thePlayer.GetComponent<Rigidbody2D>().velocity.x < 0
        if (thePlayer.LastChoice == "D")
        {
            speedx = speedmag;
        }
        if (thePlayer.LastChoice == "A")
        {
            speedx = -speedmag;
        }
        if (thePlayer.LastChoice == "W")
        {
            speedy = speedmag;
			speedx = 0f;
        }
        if (thePlayer.LastChoice == "S")
        {
            speedy = -speedmag;
			speedx = 0f;
        }
        ball.velocity = new Vector3(speedx, speedy, 0f);
        Melt();
    }
	
	// Update is called once per frame
	void Update () {
        ball.velocity = new Vector3(speedx, speedy, 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Checkpoint" && other.gameObject.tag != "Player")
        {
            if (other.gameObject.tag == "Enemy")
            {
				TakeDamage hit = other.collider.GetComponent<TakeDamage> ();

				if (hit != null) 
				{
					hit.Damage (1);
				}
                Instantiate(Effect, transform.position, transform.rotation);

            }
            Destroy(gameObject);
        }
    }
    public void Melt()
    {
        StartCoroutine("WaitAndDestroy");
    }
    public IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
 
    }

}
