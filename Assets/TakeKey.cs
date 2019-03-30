using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour {
	[SerializeField] GameController objControll;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("sasasssasa");
		objControll.Key = true;
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
