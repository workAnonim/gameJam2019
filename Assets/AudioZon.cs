using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioZon : MonoBehaviour {
	[SerializeField] GameObject sound;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		sound.SetActive (true);
	}
	void OnTriggerExit(Collider other) {
		sound.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
