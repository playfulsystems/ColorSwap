using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
	public float rotSpeed = 1.2f;

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().MoveRotation(GetComponent<Rigidbody2D>().rotation + rotSpeed);
	}
}
