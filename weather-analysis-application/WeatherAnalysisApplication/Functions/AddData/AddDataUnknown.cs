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
        static void AddDataUnknown(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local data
            bool loop = true;
            string userString = "";
            int count = 0;
            ConsoleKeyInfo userKeyInput;

            Clear();
            WriteLine("Run\\Menu\\AddData\\AddDataUnknown:");

            while (loop == true)
            {
                WriteLine("");

                if (count == 0)
                {
                    WriteLine("To start press any key, to stop press q");
                }
                else
                {
                    WriteLine("To add new day press any key, to stop press q");
                }

                userKeyInput = ReadKey();

                if (userKeyInput.Key == ConsoleKey.Q)
                {
                    return;
                }

                WriteLine("");
                WriteLine((count + 1) + " Day:");

                day[count] = count + 1;
                humidity[count] = Convert.ToByte(userString = IsDataValid("Humidity(0 - 100%):", 0, 100));
                temperature[count] = Convert.ToInt32(userString = IsDataValid("Temperature(-90°C - 60°C):", -90, 60));
                airPressure[count] = Convert.ToUInt16(userString = IsDataValid("Air pressure(900 - 1060 hPa):", 900, 1060));

                if (count == 364)
                {
                    return;
                }

                count = count + 1;
            }
        }
    }
}
