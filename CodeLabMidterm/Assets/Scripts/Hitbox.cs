using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

	public Vector3 flippedPos;
	public Vector3 nonFlippedPos;
	PlayerMovement pm;
	SpriteRenderer sr; 
	public bool nada;
	public bool rock;
	public bool paper;
	public bool scissors;
	public Sprite nadaSprite;
	public Color nadaColor;
	public Sprite rockSprite;
	public Color rockColor;
	public Sprite paperSprite;
	public Color paperColor;
	public Sprite scissorsSprite;
	public Color scissorsColor;


	// Use this for initialization
	void Start () {

		pm = GetComponentInParent<PlayerMovement> ();
		sr = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		orientation ();
		rpsShtuffs ();
		
	}

	void orientation ()
	{
		if (Input.GetKeyDown(pm.left)) 
		{
			transform.localPosition = flippedPos;
			sr.flipX = true;
		}

		if (Input.GetKeyDown(pm.right)) 
		{
			transform.localPosition = nonFlippedPos;
			sr.flipX = false;
		}
	}

	void rpsShtuffs ()
	{
		if (nada) 
		{
			sr.sprite = nadaSprite;
			sr.color = nadaColor;
		}
		if (paper) 
		{
			sr.sprite = paperSprite;
			sr.color = paperColor;
		}
		if (rock) 
		{
			sr.sprite = rockSprite;
			sr.color = rockColor;
		}
		if (scissors) 
		{
			sr.sprite = scissorsSprite;
			sr.color = scissorsColor;
		}
	}

	public void makePaper ()
	{
		paper = true;
		rock = false;
		scissors = false;
		nada = false;
	}
	public void makeRock ()
	{
		rock = true;
		paper = false;
		scissors = false;
		nada = false;
	}
	public void makeScissors ()
	{
		scissors = true;
		rock = false;
		paper = false;
		nada = false;
	}
	public void makeNada ()
	{
		nada = true;
		rock = false;
		paper = false;
		scissors = false; 
	}
}
