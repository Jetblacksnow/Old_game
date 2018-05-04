using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
	public void LoadLevel(string name)
	{
		
		Application.LoadLevel(name);
		

	}

	public void QuitRequest()
	{
		Application.Quit();
	}

}
