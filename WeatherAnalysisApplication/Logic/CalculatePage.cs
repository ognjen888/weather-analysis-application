//Name: WAP
//Autor: Ognjen Letic
//Datei: CalculatePage.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static int CalculatePage(ConsoleKeyInfo userKeyInput)
        {
            // local
            int selectedPosition = 0;

            if (userKeyInput.Key == ConsoleKey.LeftArrow) //move left
            {
                return selectedPosition = 1;
            }
            else if (userKeyInput.Key == ConsoleKey.RightArrow) //move right
            {
                return selectedPosition = 2;
            }
            else if (userKeyInput.Key == ConsoleKey.E) //edit
            {
                return selectedPosition = 3;
            }
            else if (userKeyInput.Key == ConsoleKey.Q) 
            {
                return selectedPosition = 4;
            }

            return selectedPosition;
        }
    }
}
