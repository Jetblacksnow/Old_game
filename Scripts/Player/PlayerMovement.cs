using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	//player movement variables.
	public float moveSpeed ;
	public float turnSpeed;
	public Rigidbody RB;
	//player jump variables.
	public float jumpPower;
	public float minJump;
	public float maxJump;
	public bool onGround;
	public float fallMultipliler = 2.5f;
	public float lowJumpMultiplier = 2f;

	// Use this for initialization
	void Start ()
	{
		RB = GetComponent<Rigidbody>();
		onGround = true;
		jumpPower = 0f;
		minJump = 2f;
		maxJump = 10f;

		
	}
	//void OnCollisionEnter(Collision other)
	//{
		//if (other.gameObject.CompareTag("ground"))
		//{ onGround = true; }
	//}
	// Update is called once per frame
	void FixedUpdate ()
	{ //player movement defined.
		float moveH = Input.GetAxis("Horizontal")*Time.deltaTime*turnSpeed;
		float moveV = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		// player movement execute 
		transform.Rotate(0, moveH, 0);
		transform.Translate(0, 0, moveV);
		//player jump
		if (onGround)
		{
			if (Input.GetButton("Jump"))
			{
				if (jumpPower < maxJump)
				{ jumpPower += Time.deltaTime * 10f; }
				else { jumpPower = maxJump; }
			}
			else
			{
				if (jumpPower > 0f)
				{   // i'm wanting the player to slow down while in the air. so far attempts haven't worked
					//https://www.youtube.com/watch?v=7KiK0Aqtmzc this video shows how to add some gravity in 2d
					// but where do to put it?
					// here is the code he used.modification are needed.
					//if (RB.velocity.y < 0) { RB.velocity += Vector3.up * Physics2D.gravity.y * (fallMultipliler - 1) * Time.deltaTime; }
					//else if (RB.velocity.y > 0 && !Input.GetButton("jump")) { RB.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime; }

					//transform.Translate(0, 0,Input.GetAxis("Vertical") * Time.deltaTime/50);
					//transform.Rotate(0,moveH--, 0);
					jumpPower = jumpPower + minJump;
					RB.velocity = new Vector3(jumpPower / 10f, jumpPower, 0f);
					jumpPower = 0f;
					onGround = false;
				}
			}
			//transform.Rotate(0, -10% moveH, 0);
			//transform.Translate(0, 0, -10 % moveV);

		}

		//Vector3 movement = new Vector3(moveH, 0.0f, moveV);
		
	
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("ground"))
		{ onGround = true; }
	}
}

