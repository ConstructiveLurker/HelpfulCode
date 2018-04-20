using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour 
{

	// global variable, but not public
	Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// GetAxisRaw : You're either -1 , 0 , 1
		float inputX = Input.GetAxisRaw ("Horizontal");
		float inputY = Input.GetAxisRaw ("Vertical");

		// do we have any x or y input (if so, true)
		bool isWalking = (Mathf.Abs (inputX) + Mathf.Abs (inputY) > 0);

		// set variables
		anim.SetBool ("IsWalking", isWalking);

		if (isWalking) 
		{
			anim.SetFloat ("x", inputX);
			anim.SetFloat ("y", inputY);
		}
	}
}
