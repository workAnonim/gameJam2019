using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	[SerializeField] List<ControllRoom> listRoom;
	[SerializeField] GameObject hero;
	[SerializeField] GameObject WallUp;
	[SerializeField] AudioSource soundDeath;
	public int nowIdRoom=0;
	public bool Key=false;
	// Use this for initialization
	void Start () {
		Key=false;
	}
	public void Restart(){
		listRoom [0].gameObject.SetActive (true);
		listRoom [0].Restart ();
		soundDeath.Play ();
	}
	public void WallUpAnimation(){
		WallUp.GetComponent<Animator> ().enabled = true;
	}
	public void NextRoom(){
		listRoom [nowIdRoom + 1].ChangeParentHero ();
		listRoom [nowIdRoom].gameObject.SetActive (false);

		listRoom [nowIdRoom+1].WallActiveBack();
		//listRoom [nowIdRoom + 1].gameObject.transform.localRotation = listRoom [nowIdRoom].gameObject.transform.localRotation;
		//listRoom [nowIdRoom + 1].gameObject.transform.localPosition = listRoom [nowIdRoom].gameObject.transform.localPosition;
		//hero.transform.localRotation = listRoom [nowIdRoom].gameObject.transform.localRotation;
		//hero.transform.localPosition = new Vector3 (hero.transform.localPosition.x,hero.transform.localPosition.y,-6);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
