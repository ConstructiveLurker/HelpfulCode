using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
	// load the next scene in the build index
	public void Play ()
	{
		// make sure your scenes are in your build settings!
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	// close the game
	public void Quit ()
	{
		Application.Quit ();
	}
}
