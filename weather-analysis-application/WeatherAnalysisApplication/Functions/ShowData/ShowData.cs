//Name: WAP
//Autor: Ognjen Letic
//Datei: ShowData.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: edit data

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void ShowData(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local
            bool loop = true;
            int currentPage = 1;
            int maxPage = 0;
            int lastPage;
            int maxShowData = 15;
            int dataSize = 0;
            int countTemp = 0;
            int[] dayTemp = new int[arraySize];
            byte[] humidityTemp = new byte[arraySize];
            float[] temperatureTemp = new float[arraySize];
            ushort[] airPressureTemp = new ushort[arraySize];
            ConsoleKeyInfo userKeyInput;

            dataSize = CalculateDataSize(airPressure);

            if (dataSize == 0)
            {
                Clear();
                Console.WriteLine("Run\\Menu\\ShowData:");
                Console.WriteLine("Press any key to go back.");
                RepeatWriteLine(4);
                WriteLine("╔═══════════════════════════════════╗", 80);
                WriteLine("║ There is no data                  ║", 80);
                WriteLine("╚═══════════════════════════════════╝", 80);

                ReadKey();

                return;
            }

            for (int count = 0; count < arraySize; count++)
            {
                if (day[count] != 0 && !(count > 364))
                {
                    dayTemp[countTemp] = day[count];
                    humidityTemp[countTemp] = humidity[count];
                    temperatureTemp[countTemp] = temperature[count];
                    airPressureTemp[countTemp] = airPressure[count];

                    countTemp = countTemp + 1;
                }
            }

            maxPage = dataSize / maxShowData;
            lastPage = dataSize % maxShowData;

            if (lastPage != 0)
            {
                maxPage += 1;
            }

            while (loop == true)
            {
                Clear();

                Console.WriteLine("Run\\Menu\\ShowData:");
                Console.WriteLine("              ┌─────────────────────────────────────────────────┐");
                Console.WriteLine("              │ Day: │ humidity: │ temperature: │ air pressure: │");
                Console.WriteLine("              │──────┼───────────┼──────────────┼───────────────│");

                for (int showData = CalculateShowData(currentPage); showData < maxShowData; showData++)
                {
                    if (dayTemp[showData] != 0 && !(showData > 364))
                    {
                        Console.WriteLine("              │ {0,-3}  │       {1,-3}%│       {2,-3}  °C│       {3,-4} hPa│", dayTemp[showData], humidityTemp[showData], temperatureTemp[showData], airPressureTemp[showData]);
                    }
                }

                Console.WriteLine("              ├─────────────────────────────────────────────────┤");
                Console.WriteLine("              │ Page {0,-3}│ last page [LEFT ARROW] edit [E]       │", currentPage);
                Console.WriteLine("              │         │ next page [RIGHT ARROW] quit [Q]      │");
                Console.WriteLine("              └─────────────────────────────────────────────────┘");

                userKeyInput = ReadKey();
                int selectOption = CalculatePage(userKeyInput);

                if (selectOption == 1) // turn page left
                {
                    if (currentPage > 1)
                    {
                        currentPage = currentPage - 1;
                        maxShowData -= 15;
                    }
                }
                else if (selectOption == 2) // turn page right
                {
                    if (currentPage < maxPage)
                    {
                        currentPage = currentPage + 1;
                        maxShowData += 15;
                    }
                }
                else if (selectOption == 3) // edit
                {
                    ShowDataEdit(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                    return;
                }
                else if (selectOption == 4) // exit
                {
                    loop = false;
                }
            }
        }
    }
}
