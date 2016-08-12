using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float translationFwd;
	float translationSide;

	public int speed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		translationFwd = Input.GetAxis ("Vertical") * Time.deltaTime;
		translationSide = Input.GetAxis ("Horizontal") * Time.deltaTime;

		transform.Translate (translationSide * speed, 0, translationFwd * speed);
	}
}
