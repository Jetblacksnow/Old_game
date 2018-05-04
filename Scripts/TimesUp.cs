using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimesUp : MonoBehaviour
{
	//public GameObject scoreManager;
	public Text timeIsUp;
	
	// Use this for initialization
	void Start ()
	{
		timeIsUp.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}
}
