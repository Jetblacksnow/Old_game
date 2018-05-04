using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf_AI : MonoBehaviour
{
	
	public float moveSpeed;
	public Transform target;
	public Transform Target;
	public int damage;
	public GameObject pcHealth;
	
	void OnTriggerStay(Collider other)
	{
		//go after player player
		if (other.gameObject.name == "Player" )//|| other.gameObject.tag=="Chicken")
			{
				Debug.Log("Player has entered wolfs trigger");
				transform.LookAt(target);
				transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
			}

		//Go after chicken
		if (other.gameObject.tag == "Chicken")
			{
				Debug.Log("Chicken has entered wolfs trigger");
				transform.LookAt(target);
				transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
			}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Player")
			{
				var hit = other.gameObject;
				var health = hit.GetComponent<PlayerHealth>();
				print("Wolf is attacking!");

			if (pcHealth != null)
				{

				//	pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
				}

			}

	}

}
