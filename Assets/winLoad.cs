using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		//sApplication.
		Application.LoadLevel ("WaterTest3");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
