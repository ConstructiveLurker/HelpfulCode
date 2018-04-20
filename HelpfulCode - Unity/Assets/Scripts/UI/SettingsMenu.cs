using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour 
{
	// make sure you're using UnityEngine.Audio
	public AudioMixer audioMixer;
	// lets us add our resolutionDropdown to our script to reference
	public Dropdown resolutionDropdown;
	// lets us add our graphicsDropdown to our script to reference
	public Dropdown graphicsDropdown;

	// resolution array
	Resolution[] resolutions;

	void Start ()
	{
		// recieve a list of the resolutions we can use
		resolutions = Screen.resolutions;

		// cleans up our resolution dropdown for our new resolutions
		resolutionDropdown.ClearOptions ();

		// turns our array of resolutions into a list of strings
		List <string> options = new List <string> ();

		// by default, currentResolutionIndex is 0
		int currentResolutionIndex = 0;

		// loop through each item in our resolution array and turn it into a string
		// then add it to our list
		for (int i = 0; i < resolutions.Length; i++) 
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add (option);

			// check if the resolution we're looking at is = to our resolution
			// we have to compare both the width and the height
			if (resolutions [i].width == Screen.currentResolution.width && 
				resolutions [i].height == Screen.currentResolution.height) 
			{
				// if it is, set our resolution index to i
				currentResolutionIndex = i;
			}
		}

		// adds our list of resolutions to our dropdown
		resolutionDropdown.AddOptions (options);
		// set our dropdown to our resolution index
		resolutionDropdown.value = currentResolutionIndex;
		// ensure our dropdown value matches our index
		resolutionDropdown.RefreshShownValue();
		// ensure our graphics start off at high
		graphicsDropdown.RefreshShownValue ();
	}

	//make sure you're using UnityEngine.UI (only need it for this)
	// go to Edit > Project Settings > Player > Resolution and Presentation > 
	// Standalone Player Options > then set the Display Resolution Dialogue to disabled
	// ***this gets rid of the initial resolution select window upon starting the game
	public void SetResolution (int resolutionIndex)
	{
		// we need to grab our resolution index
		Resolution resolution = resolutions [resolutionIndex];
		// set our resolution to the resolution we choose
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);
	}

	// set the volume
	public void SetVolume (float volume)
	{
		// recieve the audioMixer and set it to our float
		audioMixer.SetFloat ("Volume", volume);
	}

	// set the graphics quality
	public void SetQuality (int qualityIndex)
	{
		// look at the quality index, then change it to the index of our dropdown selection
		// can watch this by going Edit > Project Settings > Quality
		QualitySettings.SetQualityLevel (qualityIndex + 1);
	}

	// set if the game is fullscreen or not
	public void SetFullscreen (bool isFullscreen)
	{
		// change our fullscreen value to our isFullscreen bool
		Screen.fullScreen = isFullscreen;
	}
}
