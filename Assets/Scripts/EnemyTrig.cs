﻿using UnityEngine;
using System.Collections;

public class EnemyTrig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {
		Debug.Log ("The player is hit");
	}
}
