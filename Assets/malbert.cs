using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malbert : MonoBehaviour {

	public int id;
	[SerializeField] GameObject light;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		print(FindObjectOfType<ControllerHero>().m_isObjs[id]);
		if(FindObjectOfType<ControllerHero>().m_isObjs[id])
		{
			FindObjectOfType<GameConroller>().NextVideo(id);
			GetComponent<BoxCollider>().enabled = false;
			light.SetActive(true);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
