using UnityEngine;
using System.Collections;

public class CameraScriptY : MonoBehaviour {

	float rotationY;

	public float sensitivityY = 2f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		rotationY = Input.GetAxisRaw ("Mouse Y") * sensitivityY;

		transform.Rotate (new Vector3 (-rotationY, 0, 0));
	}
}
