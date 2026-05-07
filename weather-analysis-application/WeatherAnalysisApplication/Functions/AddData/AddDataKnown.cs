//Name: WAP
//Autor: Ognjen Letic
//Datei: AddData.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: add data

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void AddDataKnown(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local data
            bool loop = true;
            string userString = "";
            int userInteger= 0;
            ConsoleKeyInfo userKeyInput;

            while (loop == true)
            {
                Clear();

                WriteLine("Run\\Menu\\AddData\\AddDataKnown:");
                WriteLine("Type q and press ENTER to go back.");
                RepeatWriteLine(5);
                WriteLine("╔═══════════════════════════════╗", 80);
                WriteLine("║ Type a number between 1 - 365 ║", 80);
                WriteLine("║ and press ENTER to confirm.   ║", 80);
                WriteLine("╚═══════════════════════════════╝", 80);

                userString = IsDataValid("", 1, 365, "true");

                if (userString == "q")
                {
                    return;
                }
                else
                {
                    userInteger = Convert.ToInt32(userString);
                    loop = false;
                }
            }

            Clear();

            WriteLine("Run\\Menu\\AddData\\AddDataKnown:");
            WriteLine("");

            for (int count = 0; count < userInteger; count++)
            {
                WriteLine((count + 1) + " Day (" + (count + 1) + "/" + userInteger + "):");

                day[count] = count + 1;
                humidity[count] = Convert.ToByte(userString = IsDataValid("Humidity(0 - 100%):", 0, 100));
                temperature[count] = Convert.ToInt32(userString = IsDataValid("Temperature(-90°C - 60°C):", -90, 60));
                airPressure[count] = Convert.ToUInt16(userString = IsDataValid("Air pressure(900 - 1060 hPa):", 900, 1060));

                if (count == 364)
                {
                    return;
                }

                if((userInteger - 1) != count)
                {
                    WriteLine("");
                    WriteLine("To continue press any key, to stop press q");
                    WriteLine("");
                }
                else
                {
                    WriteLine("");
                    WriteLine("Finished, press any key to go confirm");
                    WriteLine("");
                }

                userKeyInput = ReadKey();

                if (userKeyInput.Key == ConsoleKey.Q)
                {
                    return;
                }
            }
        }
    }
}
