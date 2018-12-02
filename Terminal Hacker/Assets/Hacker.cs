using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        ShowMainMenu("Hello, Deonna\n");
    }

    void OnUserInput(string input)
    {
        print("The user typed in: " + input);
    }

    private static void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?\n");
        Terminal.WriteLine("Press E for Equifax");
        Terminal.WriteLine("Press F for Facebook");
        Terminal.WriteLine("Press R for The Rock University");
        Terminal.WriteLine("\nEnter your selection: ");
    }
}
