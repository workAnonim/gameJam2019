using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaderUp : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		Debug.Log ("other="+other.name);
		if (!other.GetComponent<Animator> ().enabled) {
			other.GetComponent<Animator> ().enabled = true;
			//other.GetComponent<HandeController> ().handObj.GetComponent<Animator> ().Play ("Move on Ladder");
			other.GetComponent<HandeController> ().activeAnimation = true;
			other.GetComponent<HandeController> ().GetComponent<Animator> ().Play ("Move on Ladder pers");
			Debug.Log ("ss2" + HandeController.instance.activeAnimation);
		}
		//other.GetComponent<Animator> ().Play ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
