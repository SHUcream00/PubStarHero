using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour {

	public Transform upPoint;
	public Transform downPoint;

	private Rigidbody2D myRigidbody;

	public float moveSpeed;

	public bool movingDown;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if(movingDown && transform.position.y < downPoint.position.y)
		{
			movingDown = false;
		}
		if(!movingDown && transform.position.y > upPoint.position.y)
		{
			movingDown = true;
		}

		if(movingDown)
		{
			myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, -moveSpeed, 0f);

		} else {
			myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, moveSpeed, 0f);
		}
	}
}
