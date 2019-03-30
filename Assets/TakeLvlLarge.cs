using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLvlLarge : MonoBehaviour {
	[SerializeField] GameController objController;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		gameObject.GetComponent<Animation> ().Play ("right");
		objController.WallUpAnimation ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
