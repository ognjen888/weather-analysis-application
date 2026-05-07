//Name: WAP
//Autor: Ognjen Letic
//Datei: WriteLine.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void WriteLine(string text, int consoleWidth = 0)
        {
            //local
            int stringLength = 0;            

            if (consoleWidth != 0)
            {
                foreach (char c in text)
                {
                    stringLength = stringLength + 1;
                }

                consoleWidth = consoleWidth - stringLength;
                consoleWidth = consoleWidth / 2;

                for (int count = 0; count < consoleWidth; count++)
                {
                    text = " " + text;
                }
            }          

            Console.WriteLine(text);
        }
    }
}
