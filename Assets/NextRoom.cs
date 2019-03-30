using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour {
	[SerializeField] GameController contolObj;
	public int id = 0;
	void OnTriggerEnter(Collider other) {
		switch(id){
		case 0:
			contolObj.NextRoom ();
			break;
		case 1:
			contolObj.Restart ();
			break;
		case 2:
			contolObj.Restart ();
			break;
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
