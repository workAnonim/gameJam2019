using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenIsTheDoor : MonoBehaviour {
	[SerializeField] GameController objController;
	[SerializeField] GameObject keySprite;
	public GameObject door;
	public int id;
	// Use this for initialization
	void Start () {
		//door.GetComponent<Animator> ().Play ("Door_close");
	}
	void OnTriggerEnter(Collider other) {
		switch (id) {
		case 0:
			//Debug.Log ("other=" + door.name);
		//if(!other.GetComponent<Animator> ().enabled){
			//other.GetComponent<Animator> ().enabled = true;
			//other.GetComponent<HandeController> ().handObj.GetComponent<Animator> ().Play ("Move on Ladder");
			//other.GetComponent<HandeController> ().activeAnimation = true;
			//other.GetComponent<HandeController> ().GetComponent<Animator> ().Play ("Move on Ladder pers down");
			//door.GetComponent<Animator> ().Play ("Door_Open");
			door.GetComponent<Animator> ().enabled = true;
			//Debug.Log ("ss2" + HandeController.instance.activeAnimation);
			break;
		case 1:
			if (objController.Key) {
				door.GetComponent<Animator> ().enabled = true;
			} else {
				keySprite.SetActive (true);
			}
			break;
		}
		//}
	}
	void OnTriggerExit(Collider other) {
		switch (id) {
		case 1:
			keySprite.SetActive (false);
			break;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
