using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlObj : MonoBehaviour {
	public int m_type;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		FindObjectOfType<ControllerHero>().activateObject(m_type);
		gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
