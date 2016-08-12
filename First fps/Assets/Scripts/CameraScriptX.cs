using UnityEngine;
using System.Collections;

public class CameraScriptX : MonoBehaviour {

	float rotationX;
	//float rotationY;

	public float sensitivityX = 2f;
	//public float sensitivityY = 2f;

	Quaternion originalRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		rotationX = Input.GetAxisRaw ("Mouse X") * sensitivityX;
		//rotationY += Input.GetAxisRaw ("Mouse Y") * sensitivityY;

		transform.Rotate (new Vector3 (0, rotationX, 0));

	}
}