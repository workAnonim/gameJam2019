using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameConroller : MonoBehaviour {
	[SerializeField] Image eyes;
	[SerializeField] GameObject m_camMenu;
	[SerializeField] VideoPlayer m_videoPlayer;
	[SerializeField] GameObject m_teleport;
	[SerializeField] GameObject m_camMenuRoom;
	[SerializeField] GameObject m_booksRoom;
	[SerializeField] GameObject m_AltarRoom;
	[SerializeField] Material screenMaterial;
	[SerializeField] List<GameObject> m_lightMalbert;
	[SerializeField] GameObject m_zombie;
	[SerializeField] Animator m_backDeath;
	[SerializeField] Animator Eye;
	[SerializeField] List<VideoClip> m_clips = new List<VideoClip>();
	[SerializeField] List<Texture> m_screens = new List<Texture>();
	// Use this for initialization
	void Start () {
		screenMaterial.mainTexture = m_screens[4];
	}
	
	public void startGame()
	{
		eyes.GetComponent<Animator>().enabled = true;

	}
	public void showTeleport()
	{
		m_teleport.SetActive(true);
	}

	public void teleport()
	{
		FindObjectOfType<HeroController>().transform.position = new Vector3(-60,2,20);
	}

	public void showLightMalbert(int id)
	{
		m_lightMalbert[id].SetActive(true);
	}
	public void startVideo()
	{
		
		m_videoPlayer.Play();
		Invoke("hideStartMenu",0.2f);
		/* FindObjectOfType<VideoPlayer>().prepareCompleted = {

		};*/
	}
	public void animBackDeath()
	{
		m_backDeath.gameObject.SetActive(true);
	}
	public void NextVideo(int id)
	{
		
		m_zombie.GetComponent<Zombi>().run = false;
		m_videoPlayer.targetCamera = Camera.main;
		m_videoPlayer.clip = m_clips[id];
		screenMaterial.mainTexture = m_screens[id];
		m_videoPlayer.Play();
		Invoke("hideVideo",10f);
		if(id == 3)
			m_camMenuRoom.gameObject.SetActive(true);
		if(id == 0)
		{
			m_booksRoom.SetActive(true);
			m_zombie.SetActive(true);
			//m_zombie.GetComponent<Zombi>().run = false;
		}
		else
		{
			m_AltarRoom.SetActive(true);
		}
	}

	void hideVideo()
	{
		m_backDeath.gameObject.SetActive(false);
		m_videoPlayer.Stop();
		if(FindObjectOfType<ControllerHero>().m_isObjs[3])
			Eye.gameObject.SetActive(true);
		m_zombie.GetComponent<Zombi>().run = true;
	}
	void hideStartMenu()
	{
		eyes.transform.parent.gameObject.SetActive(false);
		Invoke("awakeHero",6f);
		m_camMenuRoom.SetActive(false);
	}
	void awakeHero()
	{
		m_camMenu.SetActive(false);
		FindObjectOfType<ControllerHero>().showHero();
	}
	// Update is called once per frame
	public void reload()
	{
		Application.LoadLevel(0);
	}
	void Update () {
		
	}
}
