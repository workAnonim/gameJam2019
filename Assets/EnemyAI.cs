using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
	//дистанция от которой он начинает видеть игрока
	public float seeDistance = 5f;
	//дистанция до атаки
	public float attackDistance = 2f;
	//скорость енеми
	public float speed = 6;
	//игрок
	private Transform target;

	void Start ()
	{       
		target = GameObject.FindWithTag ("player").transform;
	}

	void Update ()
	{
		if (Vector2.Distance (transform.position, target.transform.position) < seeDistance) {
			if (Vector2.Distance (transform.position, target.transform.position) > attackDistance) {
				//walk
				transform.LookAt (target.transform);
				transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
			}
		} else {
			//idle
		}
	}
}