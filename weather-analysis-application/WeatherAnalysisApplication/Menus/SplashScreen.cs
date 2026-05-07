//Name: WAP
//Autor: Ognjen Letic
//Datei: SplashScreen.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void SplashScreen()
        {
            //local
            Console.CursorVisible = false;

            RepeatWriteLine(5);
            WriteLine("╔═════════════════════════════════════════════╗", 80);
            WriteLine("║ Welcome to the Weather Analysis Application ║", 80);
            WriteLine("║                                             ║", 80);
            WriteLine("║ Project: WAP                                ║", 80);
            WriteLine("║ Made by: Ognjen Letic                       ║", 80);
            WriteLine("║ Date:    4.13.2023                          ║", 80);
            WriteLine("║                                             ║", 80);
            WriteLine("║ Please press any Key to continue            ║", 80);
            WriteLine("╚═════════════════════════════════════════════╝", 80);

            ReadKey();

            Clear();
        }
    }
}
