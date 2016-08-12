using UnityEngine;
using System.Collections;

public class KameraScript : MonoBehaviour {

	float rotationX;
	float rotationY;

	public float sensitivityX = 2f;
	public float sensitivityY = 2f;

	Quaternion originalRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		rotationX += Input.GetAxisRaw ("Mouse X") * sensitivityX;
		rotationY = Input.GetAxisRaw ("Mouse Y") * sensitivityY;

		Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
		Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, -Vector3.right);

		transform.localRotation = originalRotation * xQuaternion * yQuaternion;
	}
}