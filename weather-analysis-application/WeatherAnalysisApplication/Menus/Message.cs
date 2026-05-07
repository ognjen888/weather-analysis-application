//Name: WAP
//Autor: Ognjen Letic
//Datei: Message.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void Message(string text)
        {
            Clear();

            RepeatWriteLine(10);
            WriteLine($"{text}", 80);
            WriteLine("Press any key to continue.", 80);

            ReadKey();
            Clear();
        }
    }
}
