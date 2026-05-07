//Name: WAP
//Autor: Ognjen Letic
//Datei: CalculateOption.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static int CalculateOption(ConsoleKeyInfo userKeyInput, ref int menuPosition)
        {
            // local
            int selectedPosition = 0;

            if (userKeyInput.Key == ConsoleKey.UpArrow) //move up
            {
                menuPosition = menuPosition - 1;
            }
            else if (userKeyInput.Key == ConsoleKey.DownArrow) //move down
            {
                menuPosition = menuPosition + 1;
            }
            else if (userKeyInput.Key == ConsoleKey.Enter) //confirm
            {
                selectedPosition = menuPosition + 1;
            }

            return selectedPosition;
        }
    }
}
