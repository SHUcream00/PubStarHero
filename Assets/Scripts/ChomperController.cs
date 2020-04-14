using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperController : MonoBehaviour {

	public bool trigger;

	private Rigidbody2D myRigidbody;

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();	
		InvokeRepeating ("Jump", 2.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Jump()
	{
		myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, moveSpeed, 0f);
	}

}
