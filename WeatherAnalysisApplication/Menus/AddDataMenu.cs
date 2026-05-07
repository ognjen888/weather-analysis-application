//Name: WAP
//Autor: Ognjen Letic
//Datei: main.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main
//Änderungen:
//
//Box for the User Interface
//╔════════════════════╗ ╠ ╣
//║                    ║
//╚════════════════════╝

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static int AddDataMenu(int menuPosition, int menuSize = 0)
        {
            // local data
            string[] selectString = new string[menuSize];

            for (int count = 0; count < menuSize; count++)
            {
                selectString[count] = " ";
            }

            selectString[menuPosition = CorrectMenuPosition(menuPosition, menuSize)] = "X";

            WriteLine("Run\\Menu\\AddData:");
            RepeatWriteLine(4);
            WriteLine("╔════════════════════════════════╗", 80);
            WriteLine("║ Use keys Up↑, Down↓ & ENTER    ║", 80);
            WriteLine("║ to navigate through Menu       ║", 80);
            WriteLine("║                                ║", 80);
            WriteLine("║ |" + selectString[0] + "| Add known amount of data   ║", 80);
            WriteLine("║ |" + selectString[1] + "| Add unknown amount of data ║", 80);
            WriteLine("║ |" + selectString[2] + "| Exit                       ║", 80);
            WriteLine("╚════════════════════════════════╝", 80);

            return menuPosition;
        }
    }
}
