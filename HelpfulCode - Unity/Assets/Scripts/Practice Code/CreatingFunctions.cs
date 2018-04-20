using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// write a function to take a number and double it, then return the value
	public float Banananana (float number) {
		return number * 2;
	}
	// write a function that will take two numbers, add them together, then return the value
	public float ChaosTheory (float number1, float number2) {
		return number1 + number2;
	}
	// EXAMPLE
	public float CalculateDamage (float dmg, float def, float crit, float evaison) {
		// roll a die to see if they evade
		// if they don't evade, roll a die to see if you crit
		// calculate damage
		// return damage
		return 0;
	}
	// write a function that recieves a string, if the string is "Hello World!" returns true
	public bool World (string words) {
		if (words == "Hello World!") {
			return true;
		} else {
			return false;
		}
	}
}
