using UnityEngine;
using System.Collections;

public class ResetOnRespawn : MonoBehaviour {

	private Vector3 startPosition;
	private Quaternion startRotation;
	private Vector3 startLocalScale;

	private Rigidbody2D myRigidbody;

	public AnvilController[] anvilController;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		startRotation = transform.rotation;
		startLocalScale = transform.localScale;

		anvilController = FindObjectsOfType<AnvilController> ();

		if(GetComponent<Rigidbody2D>() != null)
		{
			myRigidbody = GetComponent<Rigidbody2D>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ResetObject()
	{
		transform.position = startPosition;
		transform.rotation = startRotation;
		transform.localScale = startLocalScale;

		for(int i = 0; i < anvilController.Length; i++)
		{
			anvilController [i].myRigidbody.isKinematic = true;
			anvilController [i].theSpriteRenderer.sprite = anvilController [i].anvilStart;
		}

		if(myRigidbody != null)
		{
			myRigidbody.velocity = Vector3.zero;
		}
	}
}
