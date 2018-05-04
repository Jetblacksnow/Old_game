using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderScript : MonoBehaviour
{ // https://www.youtube.com/watch?v=aEPSuGlcTUQ . watch again, if it doesn't work. maybe find video with better rez
	public float moveSpeed = 3f;
	public float rotSpeed = 100f;

	private bool isWandering = false;
	private bool isRotatingLeft = false;
	private bool isRotatingRight = false;
	private bool isWalking = false;
	//public GameObject Edgefinder;
	//public static bool onGround;


	public void Update()
	{

	//	void OnCollisionEnter(Collision other)
		{

			if (isWandering == false)
			{
				StartCoroutine(Wander());
			}
			
		
			if (isRotatingRight == true)
			{
				transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
			}

			if (isRotatingLeft == true)
			{
				transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
			}

			if (isWalking == true)
			{
				transform.position += transform.forward * moveSpeed * Time.deltaTime;
			}
		}
	}
	IEnumerator Wander()
	{

		int rotTime = Random.Range(1, 3);
		int rotWait = Random.Range(1, 3);
		int rotLeftOrRight = Random.Range(0, 3);
		int walkWait = Random.Range(1, 2);
		int walkTime = Random.Range(1, 10);

		isWandering = true;

		yield return new WaitForSeconds(walkWait);
		isWalking = true;
		yield return new WaitForSeconds(walkTime);
		isWalking = false;
		yield return new WaitForSeconds(rotWait);
		if (rotLeftOrRight == 1)
		{

			isRotatingRight = true;
			yield return new WaitForSeconds(rotTime);
			isRotatingRight = false;
		}
		if (rotLeftOrRight == 2)
		{
			isRotatingLeft = true;
			yield return new WaitForSeconds(rotTime);
			isRotatingLeft = false;
		}
		isWandering = false;
	}

	
}
