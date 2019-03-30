using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandeController : MonoBehaviour {
	// Use this for initialization
	public bool activeAnimation;
	static HandeController _instance;
	Camera[] Cameres=new Camera[100];

	public static HandeController instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new HandeController();
			}
			return _instance;
		}
	}
	void Start () {
		activeAnimation = false;
		Cameres=FindObjectsOfType<Camera> ();

		//for (int i = 0; i < 100; i++) {
		//}
		//UnityEngine.VR.VRSettings..enabled = true;
	}
	public void OffAnimator(){
		activeAnimation = false;
		gameObject.GetComponent<Animator> ().enabled = false;
	}
	// Update is called once per frame
	void Update () {
		/*if (gameObject.transform.localPosition.y < 0) {
			gameObject.transform.localPosition = new Vector3 (0,1.5f,-7);
		}*/
		/*if(activeAnimation){
			Obj.gameObject.SetActive (false);
			jopa.gameObject.SetActive (false);
			foreach(Camera gg in Cameres){
				gg.gameObject.transform.localRotation=Quaternion.Euler (-32f, 0, 0);
				Debug.Log(gg.gameObject.name);
			}
		}*/
	}
}
