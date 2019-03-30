using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllRoom : MonoBehaviour {
	[SerializeField] List<GameObject> listDoor;
	[SerializeField] GameObject wallNextRoom;
	[SerializeField] ParticleSystem smoke;
	[SerializeField] GameObject hero;
	[SerializeField] GameObject flashLight;
	[SerializeField] GameObject floor;
	// Use this for initialization
	Vector3 beginPosition;
	void Start () {
		beginPosition = hero.transform.position;
	}
	public void CloseDoorRoom(){
		for (int i = 0; i < listDoor.Count; i++) {
			listDoor[i].GetComponent<BoxCollider>().enabled=false;
		}

	}
	public void ChangeParentHero(){
		hero.transform.parent = wallNextRoom.transform.parent;
	}
	public void Restart(){
		for (int i = 0; i < listDoor.Count; i++) {
			listDoor [i].GetComponent<OpenIsTheDoor> ().door.GetComponent<Animator> ().enabled = false;
		}
		wallNextRoom.SetActive (false);
		hero.transform.position=beginPosition;
	}
	public void TakeFlashLight(){
		hero.GetComponent<HeroController> ().Hand.enabled = true;
		flashLight.SetActive (false);
		floor.SetActive (false);
	}
	public void WallActiveBack(){
		/*for (int i = 0; i < listDoor.Count; i++) {
			listDoor[i].GetComponent<BoxCollider>().enabled=true;
			listDoor [i].gameObject.SetActive (true);
		}*/
		wallNextRoom.SetActive (true);
		smoke.loop=(false);

		//smoke.gameObject.transform.localPosition=new Vector3 (smoke.gameObject.transform.localPosition.x,smoke.gameObject.transform.localPosition.y,-4);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
