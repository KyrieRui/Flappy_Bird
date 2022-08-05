using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	Rigidbody2D rg;

	public float upForce = 100f;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")&&GM.isActive)
		{
			rg.AddForce(Vector2.up * upForce);
		}
		
	}
}
