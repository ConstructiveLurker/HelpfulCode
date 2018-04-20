using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagScript : MonoBehaviour {

	// Use this for initialization
	public int loops = 10;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < loops; i++) 
		{
			Debug.Log ("foo");
		}
	}
}
