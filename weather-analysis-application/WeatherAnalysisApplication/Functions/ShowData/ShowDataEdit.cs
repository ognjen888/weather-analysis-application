//Name: WAP
//Autor: Ognjen Letic
//Datei: ShowDataEdit.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void ShowDataEdit(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            // local
            string userInputStr = "";
            int userInputInt = 0;

            SaveSlotCreate("autosave.csv", day, humidity, temperature, airPressure, arraySize);
            SaveSlotSettingsWAPUpdate("autosave.csv");
            Message("Data has been saved to autosave.csv");

            Clear();
            WriteLine("");
            WriteLine("Type a day between 1 - 365 and press ENTER to continue or press q to");
            WriteLine("go back. If you type a day that doesnt have data you will be asked");
            WriteLine("if you want to add data");
            WriteLine("");

            userInputStr = IsDataValid("Day:", 1, 365, "true");

            if (userInputStr == "q")
            {
                return;
            }

            userInputInt = Convert.ToInt32(userInputStr);
            userInputInt = userInputInt - 1;

            Clear();

            if (day[userInputInt] == 0)
            {
                Console.WriteLine($"Day {userInputInt + 1} doesnt have any data.");
                WriteLine("1. add data");
                WriteLine("2. quit");
                WriteLine("");

                userInputStr = IsDataValid("Option:", 1, 2);

                if (userInputStr == "1")
                {
                    Console.WriteLine($"Day {userInputInt + 1}:");

                    day[userInputInt] = userInputInt + 1;
                    humidity[userInputInt] = Convert.ToByte(IsDataValid("Humidity(0 - 100%):", 0, 100));
                    temperature[userInputInt] = Convert.ToInt32(IsDataValid("Temperature(-90°C - 60°C):", -90, 60));
                    airPressure[userInputInt] = Convert.ToUInt16(IsDataValid("Air pressure(900 - 1060 hPa):", 900, 1060));
                }

                return;
            }

            Console.WriteLine($"Day: {day[userInputInt]}, Humidity: {humidity[userInputInt]}, Temperature: {temperature[userInputInt]}, Air pressure: {airPressure[userInputInt]}");
            WriteLine("1. change");
            WriteLine("2. delete");
            WriteLine("3. quit");
            WriteLine("");

            userInputStr = IsDataValid("Option:", 1, 3);

            if (userInputStr == "1")
            {
                Console.WriteLine($"Day {day[userInputInt]}:");

                humidity[userInputInt] = Convert.ToByte(IsDataValid("Humidity(0 - 100%):", 0, 100));
                temperature[userInputInt] = Convert.ToInt32(IsDataValid("Temperature(-90°C - 60°C):", -90, 60));
                airPressure[userInputInt] = Convert.ToUInt16(IsDataValid("Air pressure(900 - 1060 hPa):", 900, 1060));
            }
            else if (userInputStr == "2")
            {
                day[userInputInt] = 0;
                humidity[userInputInt] = 0;
                temperature[userInputInt] = 0;
                airPressure[userInputInt] = 0;
            }

            return;
        }
    }
}
