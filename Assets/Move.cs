using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public bool isMove;
	public Vector3 MovePosition;
	// Use this for initialization
	void Start () 
	{
		isMove = false;
	}

	void move(Vector3 position)
	{
		transform.position = Vector3.Lerp (transform.position, position, 0.1f * Time.deltaTime);
	}
	// Update is called once per frame
	void Update () 
	{
		if(isMove)
			move(MovePosition);
			//transform.position = Vector3.Lerp (transform.position, new Vector3(transform.position.x,-5,transform.position.z), 0.1f * Time.deltaTime);
	}
}
