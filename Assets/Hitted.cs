﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitted : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D collision) 
	{
		if (collision.gameObject.tag == "Player")
		{
			GM.isActive = false;
		}	
	}
}
