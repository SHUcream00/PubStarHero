using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatController : MonoBehaviour {

	public float rotateSpeed;
	public float radius;

	private Vector3 center;
	private float angle;

	// Use this for initialization
	void Start () {
		center = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		angle += rotateSpeed * Time.deltaTime;

		var offset = new Vector3 (Mathf.Sin(angle), Mathf.Cos(angle), 0f) * radius;
		transform.position = center + offset;
	}
}
