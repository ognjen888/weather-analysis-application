//Name: WAP
//Autor: Ognjen Letic
//Datei: AnalyseData.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: analyse data

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void AnalyseData(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local data
            bool loop = true;
            int menuPosition = 0;
            int selectOption = 0;
            int dataSize = 0;
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

            while (loop == true)
            {
                Clear();

                menuPosition = AnalyseMenu(menuPosition, 3);
                userKeyInput = ReadKey();

                selectOption = CalculateOption(userKeyInput, ref menuPosition);

                if (selectOption == 1)
                {
                    AnalyseDataAverage(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 2)
                {
                    AnalyseDataMinMax(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 3) 
                {
                    loop = false;
                }
            }
        }
    }
}
