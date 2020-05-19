using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game State
	int level;

	enum Screen { MainMenu, Password, Win };
	Screen currentScreen = Screen.MainMenu;

	// Use this for initialization
	void Start () {
		ShowMainMenu ();
	}

    void ShowMainMenu ()
    {
		Terminal.ClearScreen();
		Terminal.WriteLine("What would you like to hack into?");
		Terminal.WriteLine("Press 1 for local library");
		Terminal.WriteLine("Press 2 for police station");
		Terminal.WriteLine("Press 3 for NASA");
		Terminal.WriteLine("Enter your selection here:");
	}

    void OnUserInput(string input)
    {
		if (input == "menu")
		{
			ShowMainMenu();
		}
		else if (input == "1")
        {
			level = 1;
			StartGame();
        }
        else if (input == "2")
        {
			level = 2;
			StartGame();
        }
        else if (input == "3")
        {
			level = 3;
			StartGame();
        }
		else if (input == "007")
        {
			Terminal.WriteLine("Please choose a valid level Mr. Bond");
        }
        else
        {
			Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame ()
    {
		Terminal.WriteLine("You have chosen level " + level);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
