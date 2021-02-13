using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMagentaCircleController : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other) // check for collisions with objects that are triggers
	{
        if (other.gameObject.name == "Player")
		{
			other.gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;
		}

		Destroy(gameObject);
	}
}
