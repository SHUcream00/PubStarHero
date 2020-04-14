using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject deathSplosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Enemy")
		{
			//Destroy(other.gameObject);

			other.gameObject.SetActive(false);

			Instantiate(deathSplosion, other.transform.position, other.transform.rotation);


		}
	}
}
