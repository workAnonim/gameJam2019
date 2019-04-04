using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		gameObject.GetComponent<Move>().isMove = true;
		for(int i = 0; i < GameObject.FindGameObjectsWithTag("tumbs").Length; i++)
			GameObject.FindGameObjectsWithTag("tumbs")[i].GetComponent<Move>().isMove = true;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
