using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public float moveSpeed;
	private float moveForce; 
	public float leftLimit;
	public float rightLimit; 
	public bool movingRight;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector2 (moveForce, rb.velocity.y); 

		if (transform.localPosition.x >= rightLimit) 
		{
			movingRight = false;
		}

		if (transform.localPosition.x <= leftLimit) 
		{
			movingRight = true;
		}

		if (movingRight == true) 
		{
			moveForce = moveSpeed;
		}
		if (movingRight == false) 
		{
			moveForce = moveSpeed * -1;
		}
		
	}
		
}
