//Name: WAP
//Autor: Ognjen Letic
//Datei: EncryptThisStringCeaser.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static string EncryptThisStringCeaser(string text, int key = 7)
        {
            // local data
            string output = "";

            foreach (char ch in text)
            {
                output += (char)(ch - key);
            }

            return output;
        }
    }
}
