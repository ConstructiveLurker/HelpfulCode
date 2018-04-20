using UnityEngine;
using System.Collections;

public class RotationMovement : MonoBehaviour 
{
	public float rotationSpeed = 2.0f;
	public float moveSpeed = 2.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("a")) {
			//rotate counter-clockwise
			transform.RotateAround(transform.position, new Vector3(0f,0f,1f), rotationSpeed);
		}

		if (Input.GetKey ("d")) {
			//rotate counter-clockwise
			transform.RotateAround(transform.position, new Vector3(0f,0f,1f), - rotationSpeed);
		}

		if (Input.GetKey ("w")) 
		{
			// move forward (up)
			GetComponent<Rigidbody2D> ().velocity = transform.up * moveSpeed;
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);
		}
	}
}
