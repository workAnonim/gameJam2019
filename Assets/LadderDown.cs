using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("other="+other.name);
		if(!other.GetComponent<Animator> ().enabled){
			other.GetComponent<Animator> ().enabled = true;
			//other.GetComponent<HandeController> ().handObj.GetComponent<Animator> ().Play ("Move on Ladder");
			other.GetComponent<HandeController> ().activeAnimation = true;
			other.GetComponent<HandeController> ().GetComponent<Animator> ().Play ("Move on Ladder pers down");
			Debug.Log ("ss2"+HandeController.instance.activeAnimation);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
