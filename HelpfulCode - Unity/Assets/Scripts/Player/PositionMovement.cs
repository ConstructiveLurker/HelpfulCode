using UnityEngine;
using System.Collections;

public class PositionMovement : MonoBehaviour {

	// starting speed
	float startSpeed = 1.0f;
	float speed;
	// speed multiplier
	float sprintSpeed = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = transform.position;

		// sprint
		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			speed = startSpeed * sprintSpeed;
		} else {
			speed = startSpeed;
		}

		// basic movement
		if (Input.GetKey (KeyCode.W)) {
			
			movement.y += speed;
		}

		if (Input.GetKey (KeyCode.A)) {
			movement.x -= speed;
		}

		if (Input.GetKey (KeyCode.S)) {
			movement.y -= speed;
		}

		if (Input.GetKey (KeyCode.D)) {
			movement.x += speed;
		}

		transform.position = movement;
	}
}
