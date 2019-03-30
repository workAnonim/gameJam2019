using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlashLight : MonoBehaviour {
	[SerializeField] ControllRoom ControllObj;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Lox");
		ControllObj.TakeFlashLight ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
