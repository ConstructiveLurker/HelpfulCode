using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour {

	// starting speed
	float startSpeed = 1.0f;
	float speed;
	// speed multiplier
	float sprintSpeed = 1.5f;

	// Use this for initialization
	void Start () 
	{
		// Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		// create a new force Vector2
		Vector2 force = new Vector2 (0, 0);

		// sprint
		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			speed = startSpeed * sprintSpeed;
		} else {
			speed = startSpeed;
		}

		// basic movement
		if (Input.GetKey (KeyCode.W)) 
		{
			force.y += speed;
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			force.x -= speed;
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			force.y -= speed;
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			force.x += speed;
		}
			
		// make the object move
		GetComponent<Rigidbody2D> ().velocity = force;
	}
}
