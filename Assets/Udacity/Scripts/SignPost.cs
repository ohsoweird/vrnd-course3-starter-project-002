﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
		SceneManager.LoadScene ("Maze", LoadSceneMode.Single);
		// Reloads the full scene from starting position of the maze.
	}
}