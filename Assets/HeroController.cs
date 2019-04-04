using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {
	public float speed = 6.0f;
	[SerializeField] GameObject MainCamera;
	public float gravity = -9.8f;
	private CharacterController _charController;
	float coordinatYPred=0;
	private float mouseX = 0;
	private float mouseY = 0;
	private float mouseZ = 0;
	public Vector3 HeadPosition { get; private set; }
	public Quaternion HeadRotation { get; private set; }
	private const string AXIS_MOUSE_X = "Mouse X";
	private const string AXIS_MOUSE_Y = "Mouse Y";
	private static readonly Vector3 NECK_OFFSET = new Vector3(0, 0.075f, 0.08f);

	// Use this for initialization
	void Start () {
		_charController = GetComponent<CharacterController>();
		coordinatYPred =  Camera.main.transform.localRotation.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 CameraDir = MainCamera.transform.forward;
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = new Vector3 (movement.z*CameraDir.x,0, movement.z*CameraDir.z);
		movement = Vector3.ClampMagnitude(movement, speed);
		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		movement.y = gravity; 
		_charController.Move(movement);
		mouseX += Input.GetAxis(AXIS_MOUSE_X) * 5;
		if (mouseX <= -180) 
		{
			mouseX += 360;
		} 
		else if (mouseX > 180) 
		{
			mouseX -= 360;
		}
		mouseY -= Input.GetAxis(AXIS_MOUSE_Y) * 2.4f;
		mouseY = Mathf.Clamp(mouseY, -85, 85);
		mouseZ = Mathf.Lerp(mouseZ, 0, Time.deltaTime / (Time.deltaTime + 0.1f));
		HeadRotation = Quaternion.Euler (mouseY, mouseX, mouseZ);
		HeadPosition = HeadRotation * NECK_OFFSET - NECK_OFFSET.y * Vector3.up;
		Camera cam = Camera.main;
		cam.transform.localPosition = HeadPosition * cam.transform.lossyScale.y;
		cam.transform.localRotation = HeadRotation;
	}
}
