using UnityEngine;
using System.Collections;

public class CheckpointController : MonoBehaviour {

	public Sprite flagClosed;
	public Sprite flagOpen;
	public bool flagOpened;

	public AudioSource flagOpening;

	private SpriteRenderer theSpriteRenderer;

	public bool checkpointActive;

	// Use this for initialization
	void Start () {
		theSpriteRenderer = GetComponent<SpriteRenderer>();
		flagOpened = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			theSpriteRenderer.sprite = flagOpen;
			checkpointActive = true;

			if (!flagOpened) 
			{
				flagOpening.Play ();
				flagOpened = true;
			}
		}
	}
}
