//Name: WAP
//Autor: Ognjen Letic
//Datei: IsDataValid.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static string IsDataValid(string text, int min, int max, string canQuit = "")
        {
            //local
            bool loop = true;
            string userString = "";
            int userInteger;

            while (loop == true)
            {
                if (text != "") // checks if there is anything to write
                {
                    Write(text);
                }

                userString = Read();

                if (canQuit == "true") // checks if user can quit
                {
                    if (userString == "q")
                    {
                        return userString;
                    }
                }

                if (!IsDigitsOnly(userString)) // checks if string contains only numbers
                {
                    WriteLine($"Error please type a number between {min} - {max}.");
                }
                else if (IsDigitsOnly(userString))
                {
                    userInteger = Convert.ToInt32(userString);

                    if (userInteger < min || userInteger > max)
                    {
                        WriteLine($"Error please type a number between {min} - {max}.");
                    }
                    else
                    {
                        loop = false;
                    }
                }
            }

            return userString;
        }
    }
}
