//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveLoadMenu.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: analyse menu

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static int SaveLoadMenu(int menuPosition, int menuSize = 0)
        {
            // local data
            string[] selectString = new string[menuSize];

            for (int count = 0; count < menuSize; count++)
            {
                selectString[count] = " ";
            }

            selectString[menuPosition = CorrectMenuPosition(menuPosition, menuSize)] = "X";

            WriteLine("Run\\Menu\\SaveLoad:");
            RepeatWriteLine(4);
            WriteLine("╔═════════════════════════════╗", 80);
            WriteLine("║ Use keys Up↑, Down↓ & ENTER ║", 80);
            WriteLine("║ to navigate through Menu    ║", 80);
            WriteLine("║                             ║", 80);
            WriteLine("║ |" + selectString[0] + "| Save                    ║", 80);
            WriteLine("║ |" + selectString[1] + "| Load                    ║", 80);
            WriteLine("║ |" + selectString[2] + "| Exit                    ║", 80);
            WriteLine("╚═════════════════════════════╝", 80);

            return menuPosition;
        }
    }
}
