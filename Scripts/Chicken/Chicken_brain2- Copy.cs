/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_brain2 : MonoBehaviour
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
	public Rigidbody rb;

	public float placeXone;
	public float placeZone;
	public float placeXtwo;
	public float placeZtwo;
	public float placeXthree;
	public float placeZthree;
	public Transform[] randomspawn;
	//public Vector3 Spawn;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		placeXone = Random.Range(-168, -25);
		placeZone = Random.Range(-180, -30);
		randomspawn = new Vector3[4];

		randomspawn[0] = transform.position = new Vector3(placeXone, 5, placeZone);

		placeXtwo = Random.Range(57, 184);
		placeZtwo = Random.Range(-32, -187);

		randomspawn[1] = transform.position = new Vector3(placeXtwo, 7, placeZtwo);



	}
	void Update ()
	{
		if (transform.position.y <= -2)
		{
			transform.position = new Vector3();
		}
		if (gotcha)
		{
			var player = GameObject.Find("Player");
			transform.position = player.transform.position + (player.transform.forward *1.1f);
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
				transform.position = randomspawn;
				/*placeX = Random.Range(-168, -25);
				placeZ = Random.Range(-180, -30);
				transform.position = new Vector3(placeX, 5, placeZ);
				*/ /*
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

			if (this.gameObject.activeInHierarchy == false)
			{
				transform.position = randomspawn[0].position;
				
			/*	placeX = Random.Range(-168,-25);
				placeZ = Random.Range(-180, -30);
				transform.position = new Vector3(placeX, 5, placeZ);
				gameObject.SetActive(true);
				rb.velocity = Vector3.zero;
			
				transform.Translate(0, 0, 0);
				*//*

			}
		}
	}

	


}
*/