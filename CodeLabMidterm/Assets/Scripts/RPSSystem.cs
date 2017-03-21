using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPSSystem : MonoBehaviour {

	public int handNumber;
	public bool rock;
	public Color rockColor;
	public bool paper;
	public Color paperColor;
	public bool scissors;
	public Color scissorsColor;
	public GameObject rockBlock;
	public GameObject paperBlock;
	public GameObject scissorsBlock; 
	public GameObject hitbox;
	public KeyCode shift;
	public KeyCode create;
	public KeyCode destroy;
	public int shiftCooldown;
	public int shiftCooldownLimit;
	public bool canShift = true;
	public bool destroyMode;


	Hitbox hb;
	SpriteRenderer sr;
	SpriteRenderer hbsr; 

	// Use this for initialization
	void Start () {

		hb = hitbox.GetComponent<Hitbox> (); 
		hbsr = hitbox.GetComponent<SpriteRenderer> (); 
		sr = GetComponent<SpriteRenderer> ();
		handNumber = Random.Range (1, 3);

		
	}
	
	// Update is called once per frame
	void Update () {

		handHandler ();
		visiuals ();
		rpsShiftController ();

		
	}


	void handHandler ()
	{
		if (handNumber == 1) 
		{
			rock = true;
			paper = false;
			scissors = false;
		}
		if (handNumber== 2) 
		{
			rock = false;
			paper = true;
			scissors = false;;
		}
		if (handNumber == 3) 
		{
			rock = false;
			paper = false;
			scissors = true;
		}

		if (handNumber > 3) 
		{
			handNumber = 1;
		}
	}

	void visiuals ()
	{
		if (rock) 
		{
			sr.color = rockColor;
			hbsr.color = rockColor;
			hbsr.sprite = hb.rockSprite;  
		}
		if (paper) 
		{
			sr.color = paperColor;
			hbsr.color = paperColor;
			hbsr.sprite = hb.paperSprite; 

		}

		if (scissors) 
		{
			sr.color = scissorsColor;
			hbsr.color = scissorsColor;
			hbsr.sprite = hb.scissorsSprite; 
		}
	}

	void rpsShiftController ()
	{
		if (canShift == true && destroyMode == false) 
		{
			if (Input.GetKeyDown (shift)) 
			{
				handNumber++;
				canShift = false; 
			}
		}

		if (canShift == false) 
		{
			shiftCooldown++; 
		}

		if (shiftCooldown >= shiftCooldownLimit) 
		{
			canShift = true;
			shiftCooldown = 0;
		}

	}
}
