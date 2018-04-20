using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionAssignment : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		int num1 = One (100);
		int num2 = Two (4);
		int num3 = Three (3);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	// Create a function that calls itself (recursion) that will add all the numbers from 1 up to the passed variable
	// Num1 would be equal to the sum of all the numbers from 1 to 100
	public int One (int num) 
	{
		if (num == 0) 
		{
			return num;
		}
		return num + One (num - 1);
	}

	// Create a function that calls itself (recursion) that will find the factorial of a given number.
	// Num2 would be equal to 4!, or 4*3*2*1
	public int Two (int num)
	{
		if (num == 1) 
		{
			return num;
		}
		return num * One (num - 1);
	}

	// Create a recursive function that gives you the Fibbonacci number at a given index.
	// Fibbonacci Sequence:
	// 0	1	2	3	4	5	6	7	8
	// 0	1	1	2	3	5	8	13	21
	// The fibbonacci sequence is found by adding the previous two indicies.
	// E.g. The 4th value in the Fib. Sequence is found by adding the 3rd and 2nd values together, or 2+1
	// The first two values of the Fib. Sequence are given as their index, so index 0 has a value of 0, and index 1 has a value of 1
	// Num3 would have a value of 34
	public int Three (int num)
	{
		if (num <= 1) 
		{
			return num;
		}
		return Three (num - 1) + Three (num - 2);
	}
}
