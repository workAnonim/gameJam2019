using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOne : MonoBehaviour {
	[SerializeField] GameController objControll;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		objControll.Restart();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
