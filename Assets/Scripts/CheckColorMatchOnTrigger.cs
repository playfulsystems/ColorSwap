using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckColorMatchOnTrigger : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Color myColor = GetComponent<SpriteRenderer>().color;
		Color collisionColor = collision.gameObject.GetComponent<SpriteRenderer>().color;

		if (myColor != collisionColor)
		{
			Time.timeScale = 0;
		}
	}
}
