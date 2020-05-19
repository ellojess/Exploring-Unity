using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Game State
	int level;
	enum Screen { MainMenu, Password, Win };
	Screen currentScreen;

	// Use this for initialization
	void Start() {
		ShowMainMenu();
	}

	void ShowMainMenu()
	{
        currentScreen = Screen.MainMenu;
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
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
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

    void StartGame()
	{
		currentScreen = Screen.Password;
		Terminal.WriteLine("You have chosen level " + level);
		Terminal.WriteLine("Please enter your password: ");

	}
}