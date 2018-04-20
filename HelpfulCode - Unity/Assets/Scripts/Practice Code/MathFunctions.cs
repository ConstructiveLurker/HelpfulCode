using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions 
{
	// return the value for pi
	// to calculate pi, pi = circumference / diameter
	public float Pi () 
	{
		return 3.141593f;
	}

	// convert degrees to radians
	public float DegreeToRadian (float degree) 
	{
		return (degree * Pi () / 180);
	}

	// convert radians to degrees
	public float RadianToDegree (float radian) 
	{
		return (Pi () * 180 / radian);
	}

	// return the absolute value of a float
	public float AbsoluteValueFloat (float num1) 
	{
		if (num1 >= 0) 
		{
			return num1;
		} else {
			return -num1;
		}
	}

	// return the absolute value of an int
	public int AbsoluteValueInt (int num1)
	{
		if (num1 >= 0) {
			return num1;
		} else {
			return -num1;
		}
	}

	// compares two numbers (floats) and returns true if they're approximately the same
	public bool Approximately (float num1, float num2)
	{
		if (num1 >= num2 - 1 && num1 <= num2 + 1) {
			return true;
		} else {
			return false;
		}
	}

	// recieves two numbers, and returns the largest of the two
	public float MaxFloat (float num1, float num2)
	{
		if (num1 >= num2) 
		{
			return num1;
		} else {
			return num2;
		}
	}

	// recieves two numbers, and returns the largest of the two
	public int MaxInt (int num1, int num2)
	{
		if (num1 >= num2) 
		{
			return num1;
		} else {
			return num2;
		}
	}

	// recieves two numbers, and returns the smallest of the two
	public float MinFloat (float num1, float num2)
	{
		if (num1 <= num2) 
		{
			return num2;
		} else {
			return num1;
		}
	}

	// recieves two numbers, and returns the smallest of the two
	public int MinInt (int num1, int num2)
	{
		if (num1 <= num2) 
		{
			return num2;
		} else {
			return num1;
		}
	}

	// recieves a number (int) and a power (int) and returns the number raised to the power given
	public int Pow (int num1, int power) 
	{
		int total = num1;
		if (power > 0) 
		{
			for (int i = 0; i < power - 1; i++) 
			{
				total = total * num1;
			}
			return total;
		}
		if (power < 0) {
			for (int i = 0; i < power - 1; i++) {
				total = total * num1;
			}
			return 1 / total;
		} else {
			return 1;
		}
	}

	// calculates the square root of the given number (int)
	public float SquareRoot (int num1)
	{
		float squareRoot = 0;
		double stageUpper = 0;
		double stageLower = 0;

		// step 1
		// if the number is <= 0, return 0
		if (num1 <= 0) 
		{
			return 0;
		}
		// while the square root is < 100, see if the number is greather than the squareRoot * squareRoot, and get the first upper and lower umbers
		while (squareRoot < 100) 
		{
			// if the number is greater than the squareRoot, increase num
			if (num1 > squareRoot * squareRoot) {
				num1++;
			// otherwise, set upper and lower values to find the square root
			} else {
				stageUpper = squareRoot;
				stageLower = squareRoot - 1;

				//do a check to see if either is the actual solution before doing more math
				if(squareRoot * squareRoot == num1)
				{
					return squareRoot;
				}
				break;
			}
		}
		// step 2
		int num2 = 0;

		// while the square root doesn't equal the number your finding the square root for, do this
		while (!(((stageLower + stageUpper / 2.0) * (stageLower + stageUpper / 2.0)) == num1)) {
			num2++;

			// stop after a certain number of iterations
			if (num2 > 15)
			{
				break;
			}

			//if (midpoint between upper and lower)^2 is greater than the desired value, need to shrink upper
			if ((((stageLower + stageUpper) / 2.0)*(stageLower + stageUpper)/2) > num1)
			{
				stageUpper = ((((stageLower + stageUpper) / 2.0) +(stageUpper))/2.0);
			}

			//if (midpoint between upper and lower)^2 is less than the desired value, increase the lower
			else {
				stageLower = ((((stageLower + stageUpper) / 2.0) + (stageLower)) / 2.0);
			}

			// if the square root is within a small percent error, return
			if ((((stageLower + stageUpper / 2.0) * (stageLower + stageUpper / 2.0)) >= num1 - .00001f && (((stageLower + stageUpper / 2.0) * (stageLower + stageUpper / 2.0)) <= num1 + .000001f)))
			{
				break;
			}
		}

		// return the square root
		return ((float)((stageLower + stageUpper) / 2.0));
	}
}