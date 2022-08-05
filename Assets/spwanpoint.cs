using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanpoint : MonoBehaviour {

	public GameObject colume;

	public float colddown = 2f;

	float nextSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
		{
			nextSpawn = Time.time + colddown;
			
			Vector3 spwanP = transform.position;
			spwanP.y += Random.Range(-1.5f,2.5f);
			Instantiate(colume,spwanP,transform.rotation);	
		}
		
	}
}
