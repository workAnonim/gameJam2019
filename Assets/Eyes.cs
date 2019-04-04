using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void endAnimation()
	{
		FindObjectOfType<GameConroller>().startVideo();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
