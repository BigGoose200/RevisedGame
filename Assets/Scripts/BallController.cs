using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other) // check for collisions with objects that are triggers
	{

		GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
		if (balls.Length == 1) 
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // This will load the next scene
		}

		Destroy(gameObject);
	}

}
