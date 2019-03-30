using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {
	public float speed = 6.0f;
	[SerializeField] GameObject MainCamera;
	public Animator Hand;
	public float gravity = -9.8f;
	private CharacterController _charController;
	float coordinatYPred=0;
	float coordinatYPred2=0;
	// Use this for initialization
	void Start () {
		_charController = GetComponent<CharacterController>();
		coordinatYPred =  Camera.main.transform.localRotation.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(MainCamera.transform);
		//Debug.Log(MainCamera.transform.localRotation.eulerAngles);
		//coordinatYPred2=MainCamera.transform.eulerAngles.y;
		//transform.Rotate(new Vector3(0,MainCamera.transform.eulerAngles.y-coordinatYPred,0),Space.World);
		//Vector3 newDir = Vector3.RotateTowards(transform.forward, (MainCamera.transform.position-transform.position), 0f, 0.0F);
		//coordinatYPred=coordinatYPred2;
		//if (coordinatYPred != Camera.main.transform.localRotation.eulerAngles.y) {
		/*Debug.Log( Camera.main.transform.eulerAngles.y);
		Debug.Log( Camera.main.transform.localRotation.eulerAngles.y+"Camera.main.transform.localRotation.eulerAngles.y");
		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, Camera.main.transform.localRotation.eulerAngles.y, transform.eulerAngles.z);
		coordinatYPred = Camera.main.transform.localRotation.eulerAngles.y;
		Debug.Log( Camera.main.transform.forward+"Camera.main.transform.localRotation.eulerAngles.y");*/
		//}
		/*float deltaX = Input.GetAxis ("Horizontal") * speed;
		float deltaY = Input.GetAxis ("Vertical") * speed;
		Vector3 movement = new Vector3 (deltaX,0,deltaY);
		movement = Vector3.ClampMagnitude (movement,speed);
		movement.y = gravity;
		movement *= Time.deltaTime;
		movement = transform.TransformDirection (movement);
		_charController.Move (movement);
		*/
		Vector3 CameraDir = MainCamera.transform.forward;
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = new Vector3 (movement.z*CameraDir.x,0, movement.z*CameraDir.z);
		movement = Vector3.ClampMagnitude(movement, speed);
		//Debug.Log(CameraDir);
		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement); 
		//movement.y = gravity; 
		movement.y = gravity; 
		_charController.Move(movement);
	}
}
