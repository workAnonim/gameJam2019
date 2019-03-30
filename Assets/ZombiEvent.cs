using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiEvent : MonoBehaviour {
	[SerializeField] GameObject zombi;
	[SerializeField] GameObject light;
	[SerializeField] GameObject flashLight;
	[SerializeField] GameObject zombiBorder;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other) {
		
		light.SetActive (false);
		flashLight.SetActive (false);
		Invoke ("ActiveLight", 1f);
		Invoke ("RunZombi", 10f);
		gameObject.SetActive (false);
	}
	void RunZombi(){
		zombi.GetComponent<Zombi> ().Run ();
	}
	void ActiveLight(){
		zombi.SetActive (true);
		light.SetActive (true);
		flashLight.SetActive (true);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
