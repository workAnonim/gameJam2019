using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerHero : MonoBehaviour {
	[SerializeField] GameObject m_hero;
	[SerializeField] GameObject m_heroHend;
	[SerializeField] GameObject m_shot;
	public bool[] m_isObjs = new bool[5];
	// Use this for initialization
	void Start () 
	{

		for(int i = 0; i < m_isObjs.Length; i++)
			m_isObjs[i] = false;
	}
	public void showHero()
	{
		m_hero.SetActive(true);
	}
	
	public void activateObject(int type)
	{
		m_isObjs[type] = true;
		switch(type)
		{
			case 0:
				/* FindObjectOfType<GameConroller>().showTeleport();*/
				FindObjectOfType<GameConroller>().showLightMalbert(type);
			break;
			case 1:
				m_heroHend.GetComponent<Animator>().Play("HendMajick");
				FindObjectOfType<GameConroller>().showLightMalbert(type);
			break;
			case 2:
				m_heroHend.GetComponent<Animator>().Play("CutHero");
				FindObjectOfType<GameConroller>().showLightMalbert(type);
			break;
			case 3:
				FindObjectOfType<GameConroller>().animBackDeath();
				FindObjectOfType<GameConroller>().NextVideo(type);
				m_hero.transform.position = new Vector3(0,2,0);
			break;
		}
	}
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown( KeyCode.Space ) && m_isObjs[1]   )
		{
			GameObject clone = Instantiate(m_shot,new Vector3(m_hero.transform.position.x,m_hero.transform.position.y+1,m_hero.transform.position.z),m_heroHend.transform.parent.rotation);
			m_heroHend.GetComponent<Animator>().Play("shot");
			//clone.transform.parent = m_hero.transform.parent;
		}

		if (Input.GetMouseButtonDown(0)&& m_isObjs[2])
		{
			print(Input.GetMouseButtonDown(0));
			m_heroHend.GetComponent<Animator>().Play("CutHero");
		}
	}
}
