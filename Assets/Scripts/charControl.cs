﻿using UnityEngine;
using System.Collections;

public class charControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	float speed = 9f;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate(Vector2.right * speed * Time.deltaTime);    
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate(-Vector2.right * speed * Time.deltaTime);   
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(-Vector2.up * speed * Time.deltaTime);  
		}

	}
}
	
	
