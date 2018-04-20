using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingMath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MathFunctions math = new MathFunctions();

		float pi = math.Pi();
		float radian = math.DegreeToRadian (180);
		float degree = math.RadianToDegree (pi / 2);
		float absFloat = math.AbsoluteValueFloat (-5.25f);
		int absInt = math.AbsoluteValueInt (-5);
		bool approx = math.Approximately (5, 5.1f);
		float maxFloat = math.MaxFloat (5.2f, 9.3f);
		int maxInt = math.MaxInt (4, 7);
		float minFloat = math.MinFloat (5.2f, 9.3f);
		int minInt = math.MinInt (4, 7);
		int pow = math.Pow (5, 2);
		float squareRoot = math.SquareRoot (5);
	}
}
