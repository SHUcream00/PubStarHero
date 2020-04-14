using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

	public int currentHealth;
	public int startingHealth;

	public GameObject deathSplosion;


	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(int amount)
	{
		currentHealth -= amount;

		if (currentHealth <= 0) 
		{
			gameObject.SetActive (false);
			currentHealth = startingHealth;
			Instantiate(deathSplosion, transform.position, transform.rotation);
		}
	}
}
