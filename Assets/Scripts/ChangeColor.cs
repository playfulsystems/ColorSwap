using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
	public Color[] colors;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		int randColor = Random.Range(0, colors.Length);
		collision.gameObject.GetComponent<SpriteRenderer>().color = colors[randColor];

		Destroy(gameObject);
	}
}
