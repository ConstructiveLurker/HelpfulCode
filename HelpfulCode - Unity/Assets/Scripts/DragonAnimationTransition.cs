using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAnimationTransition : MonoBehaviour 
{

	Animator dragonAnim;

	// Use this for initialization
	void Start () 
	{
		dragonAnim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			dragonAnim.SetInteger ("AnimationState", 0);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			dragonAnim.SetInteger ("AnimationState", 1);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			dragonAnim.SetInteger ("AnimationState", 2);
		}
	}
}
