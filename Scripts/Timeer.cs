using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeer : MonoBehaviour
{
	public float myTimer= 99;
	public Text timerText;
	public float startTime;
	public Text timeIsUp;
	public Text tryAgain;
	public Text quitGame;

	void Start ()
	{
		Time.timeScale = 1;
		//startTime = Time.time;
		timerText = GetComponent<Text>();
		timeIsUp.GetComponent<Text>().enabled = false;
		tryAgain.GetComponent<Text>().enabled = false;
		quitGame.GetComponent<Text>().enabled = false;

	}
	
	// Update is called once per frame
	void Update ()
	{
		startTime -= Time.deltaTime;
		timerText.text = "" + startTime;



		float t = /*Time.time - lolz, so it was this part that was making it count with -0.-0*/
			startTime; 
		string minutes = ((int)t / 60).ToString();
		string seconds = (t % 60).ToString("f0");
		timerText.text = minutes + ":" + seconds;
		//myTimer -= Time.deltaTime;
		//timerText.text = myTimer.ToString("f0");
		print(startTime);

		if (startTime <= 0)
		{
			timerText.text = "times up";
			timeIsUp.GetComponent<Text>().enabled = true;
			tryAgain.GetComponent<Text>().enabled = true;
			quitGame.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
	}
}
