using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_brain : MonoBehaviour
{   // alright 5th-ish attempt.
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	private bool gotcha;
	public int points = 10;
	public int pointloss = 5;
	public float runSpeed;
	public GameObject Chicky;
	public bool chickyon;
	public float placeX;
	public float placeZ;
	public Rigidbody rb;
	//public Vector3 Spawn;

	void Start()
	{
		rb = GetComponent<Rigidbody>();	
	}
	void Update ()
	{
		
		if (gotcha)
		{
			var player = GameObject.Find("Player");
			transform.position = player.transform.position + (player.transform.forward *1.1f);
			
		
		}
		if (transform.position.y <= -5)//||transform.position.x<= -195|| transform.position.x <=195 || transform.position.z <=65|| transform.pos //transform.position.z<=-189) 
		{
			placeX = Random.Range(-168, 168);
			placeZ = Random.Range(-180, -30);
			transform.position = new Vector3(placeX, 5, placeZ);
			gameObject.SetActive(true);
			rb.velocity = Vector3.zero;
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "Player" || other.gameObject.name.Contains("Wolf"))
		{
			
			Debug.Log("Player has entered chickens trigger");
			var WanderScript = this.gameObject.GetComponent<WanderScript>();
			WanderScript.enabled = false;
			transform.LookAt(target);
			transform.Translate(Vector3.back * runSpeed * Time.deltaTime);
		}
		else 
		{
			
			var WanderScript= gameObject.GetComponent<WanderScript>();
				WanderScript = this.gameObject.GetComponent<WanderScript>();
					WanderScript.enabled = true;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Player")
		{
			var WanderScript = this.gameObject.GetComponent<WanderScript>();
			WanderScript.enabled = false;
			gotcha = true;

		}
		if (other.gameObject.name.Contains("Wolf"))
		{
			ScoreManager.SubtractPoints(pointloss);
			this.gameObject.SetActive(false);
			if (this.gameObject.activeInHierarchy == false)
			{
				placeX = Random.Range(-168, 168);
				placeZ = Random.Range(-180, -30);
				transform.position = new Vector3(placeX, 5, placeZ);
				gameObject.SetActive(true);
				rb.velocity = Vector3.zero;

				transform.Translate(0, 0, 0);
				

			}
		}

		if (other.gameObject.name.Contains("Cage") && gotcha)
		{
			ScoreManager.AddPoints(points);
			this.gameObject.SetActive(false);
			gotcha = false;
			var playerspeed = GetComponent<PlayerMovement>();




			if (this.gameObject.activeInHierarchy == false)
			{
				placeX = Random.Range(-168,168);
				placeZ = Random.Range(-180, -30);
				transform.position = new Vector3(placeX, 7, placeZ);
				gameObject.SetActive(true);
				rb.velocity = Vector3.zero;
			
				transform.Translate(0, 0, 0);
				//transform.Rotate(0,0,0);

			}
			//Destroy(this.gameObject); */
		}
	}
	


}
