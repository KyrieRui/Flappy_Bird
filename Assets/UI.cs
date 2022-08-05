using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text score;
	public GameObject gameover;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score:"+ GM.score;

		if(!GM.isActive)
		{
			gameover.SetActive(true);
		}
		
	}
}
