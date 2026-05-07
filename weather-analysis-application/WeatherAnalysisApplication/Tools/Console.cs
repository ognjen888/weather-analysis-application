//Name: WAP
//Autor: Ognjen Letic
//Datei: Console.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void Write(string text)
        {
            Console.Write(text);
        }

        static void Clear()
        {
            Console.Clear();
        }

        static string Read()
        {
            // local data
            string userInput = "";

            userInput = Console.ReadLine();

            return userInput;
        }

        static ConsoleKeyInfo ReadKey()
        {
            // local data
            ConsoleKeyInfo userKeyInput;

            userKeyInput = Console.ReadKey();

            return userKeyInput;
        }
    }
}
