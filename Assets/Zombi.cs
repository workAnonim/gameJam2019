using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour {
	[SerializeField] GameObject hero;
	[SerializeField] GameController objController;
	[SerializeField] GameObject border;
	[SerializeField] GameObject pers;
	[SerializeField] GameObject apple;
	[SerializeField] GameObject lose;
	public float speedRotation;
	public float speedMove;
	public bool run = false;
	bool run2 = false;
	bool atack = false;
	// Use this for initialization
	void Start () {
		run=false;
	}
	public void Run(){
		//run=true;
	}

	void OnTriggerEnter(Collider other) {
		/* objController.Restart();
		gameObject.SetActive (false);
		border.SetActive (false);
		eventZombi.SetActive (false);
		doorwin.SetActive (true);*/
		if(other.name == "Hero")
		{
			//FindObjectOfType<HeroController>().transform.position = new Vector3(-60,2,20);
			if(!FindObjectOfType<ControllerHero>().m_isObjs[2])
			{
				FindObjectOfType<GameConroller>().animBackDeath();
				pers.GetComponent<Animator>().Play("Idle");
				Invoke("loser",1f);
			}
		}
		run = false;
		Invoke("Run",3f);
	}
	void loser()
	{
		lose.SetActive(true);
	}
	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.gameObject.name == "book")
		{
			gameObject.SetActive(false);
			Instantiate(apple,transform.position,transform.rotation);
		}
	}

	// Update is called once per frame
	void Update () {
		if(run){
			if (Vector2.Distance (transform.position, hero.transform.position) < 30) 
			{
				if(!run2){
					pers.GetComponent<Animator>().Play("crawl");
					run2 = true;
				}
				if (Vector2.Distance (transform.position, hero.transform.position) < 3) 
				{
					atack = true;
					pers.GetComponent<Animator>().Play("attack");
				}
				else
				{
					pers.GetComponent<Animator>().Play("crawl");
					atack = false;
				}
				var look_dir = hero.transform.position - gameObject.transform.position;
				look_dir.y = 0;
				gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, Quaternion.LookRotation (look_dir), speedRotation * Time.deltaTime);
				gameObject.transform.position += gameObject.transform.forward * speedMove * Time.deltaTime;
			}
			else 
			{
				pers.GetComponent<Animator>().Play("Idle");
				run2 = false;
			}
		}
		
	}
}
