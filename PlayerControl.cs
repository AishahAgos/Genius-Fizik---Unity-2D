using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl : MonoBehaviour {

	//DECLARATION

	float dirX;	//dirX contain move direction in X axis
	public float moveSpeed = 5f, jumpForce = 125f;	//these variable are adjustable in Inspector
	Rigidbody2D rb;	//reference to rigidbody2D component

	bool facingRight = true;
	Vector3 localScale;

	// Use this for initialization
	void Start () {
		localScale = transform.localScale;
		rb = GetComponent<Rigidbody2D> (); //get rigidbody2D to operate it
	}

	// Update is called once per frame
	void Update () {
		//Get dirX value when any of UI buttons is pressed
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal");

		//if jump button is pressed then doJump method is invoked
		if(CrossPlatformInputManager.GetButtonDown("Jump"))
			DoJump();
	}

	void FixedUpdate()
	{
		//pass a velocity to rigidbidy2D component according to dirX value multiplied by move speed
		rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
	}

	//invoked when jump button is pressed
	public void DoJump(){
		//simple check to not allow the player to jump while in the air
		if(rb.velocity.y == 0){
			SoundManagerScript.PlaySound ("Jump");
			//add force to rigidbody2D component in Y direction
			rb.AddForce (new Vector2(0,jumpForce), ForceMode2D.Force);
			//SoundManagerScript.PlaySound ("Land");
		}
	}


	void LateUpdate()
	{		
		CheckWhereToFace ();
	}

	void CheckWhereToFace ()
	{
		if (dirX > 0)
			facingRight = true;
		else if (dirX < 0)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;
	}

}
