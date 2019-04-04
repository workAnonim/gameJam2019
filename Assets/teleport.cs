using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		FindObjectOfType<GameConroller>().teleport();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
