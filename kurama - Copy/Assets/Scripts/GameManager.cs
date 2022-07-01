using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public collect coll;
	bool gamehasended = false;
	public float restartdelay = 1f;
	public void EndGame()
	{
		if (gamehasended == false)
		{
			gamehasended = true;
			Debug.Log("level over");
			Invoke("restart", restartdelay);
		}
	}
	void restart()
	{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}