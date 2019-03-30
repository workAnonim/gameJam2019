using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour {
	[SerializeField] GameObject hero;
	[SerializeField] GameController objController;
	[SerializeField] GameObject border;
	[SerializeField] GameObject eventZombi;
	[SerializeField] GameObject doorwin;
	public float speedRotation;
	public float speedMove;
	bool run=false;
	// Use this for initialization
	void Start () {
		run=false;
	}
	public void Run(){
		run=true;
	}
	void OnTriggerEnter(Collider other) {
		objController.Restart();
		gameObject.SetActive (false);
		border.SetActive (false);
		eventZombi.SetActive (false);
		doorwin.SetActive (true);
	}
	// Update is called once per frame
	void Update () {
		if(run){
			var look_dir = hero.transform.position - gameObject.transform.position;
			look_dir.y = 0;
			gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (look_dir), speedRotation * Time.deltaTime);
			gameObject.transform.position += gameObject.transform.forward * speedMove * Time.deltaTime;
		}
	}
}
