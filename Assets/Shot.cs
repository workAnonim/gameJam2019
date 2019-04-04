using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("end",4f);
	}
	void end()
	{
		Destroy(gameObject);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.name != "Hero")
			Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,0.05f);
	}
}
