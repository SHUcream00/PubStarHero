using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

	public GameObject projectile;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("FireProjectile", 0f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void FireProjectile()
	{
		Instantiate(projectile, firePoint.position, firePoint.rotation);
	}
}
