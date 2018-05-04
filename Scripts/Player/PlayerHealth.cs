using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	
	public const int maxHealth = 100;
	public int currentHealth = maxHealth;

	public Text hp;
	public Text maxHP;
	public Text youDied;
	public Text tryAgain;
	public Text quitGame;
	void Start()
	{
		youDied.GetComponent<Text>().enabled = false;
		tryAgain.GetComponent<Text>().enabled = false;
		quitGame.GetComponent<Text>().enabled = false;
	}
	void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
		
	}

	public void TakeDamage(int amount)
	{
        Debug.Log(string.Format("Take damage {0}", currentHealth));
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth=0;
			Time.timeScale = 0;
			youDied.GetComponent<Text>().enabled = true;
			tryAgain.GetComponent<Text>().enabled = true;
			quitGame.GetComponent<Text>().enabled = true;

		}
	}
}
