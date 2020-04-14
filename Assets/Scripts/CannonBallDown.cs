using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallDown : MonoBehaviour {

	public float moveSpeed;
	public float delay;

	private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		myRigidbody.velocity = new Vector3(myRigidbody.velocity.y, -moveSpeed, 0f);
		Melt ();
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

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag != "Bullet")
		{
			Destroy(gameObject);
		}
	}
}
