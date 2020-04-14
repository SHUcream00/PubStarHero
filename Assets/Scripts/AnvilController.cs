using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnvilController : MonoBehaviour {

	public Sprite anvilStart;
	public Sprite anvilDrop;

	public SpriteRenderer theSpriteRenderer;

	private LevelManager theLevelManager;

	public Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
		theSpriteRenderer = GetComponent<SpriteRenderer>();
		theLevelManager = FindObjectOfType<LevelManager> ();
		myRigidbody = GetComponent<Rigidbody2D>();
		myRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "Player") {
			theLevelManager.HurtPlayer(6);		
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			theSpriteRenderer.sprite = anvilDrop;
			myRigidbody.isKinematic = false;
		}
	}
		
}
