using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWander : MonoBehaviour {
	
	public float speed = 5.0f;
	public float rotSpeed = 10.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Wander();
	}

	void Wander(){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	      
		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "wall")
		{
			Debug.Log("chicken triggered wall");
			transform.Rotate(turnAround * rotSpeed * Time.deltaTime);
					
		}
		
	}
}
