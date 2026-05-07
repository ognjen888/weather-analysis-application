//Name: WAP
//Autor: Ognjen Letic
//Datei: CorrectMenuPosition.cs
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
        static int CorrectMenuPosition(int menuPosition, int menuSize)
        {
            //local

            if (menuPosition < 0)
            {
                menuPosition = menuSize - 1;
            }
            else if (menuPosition > menuSize - 1)
            {
                menuPosition = 0;
            }

            return menuPosition;
        }
    }
}
