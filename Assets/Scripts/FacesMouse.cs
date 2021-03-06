﻿using UnityEngine;
using System.Collections;

public class FacesMouse : MonoBehaviour {

	public float rotSpeed = 90f;


	// Update is called once per frame
	void Update ()
	{
		Vector3 mouseScreen = Input.mousePosition;
		Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);
		transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
	}
}
