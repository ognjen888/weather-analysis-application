//Name: WAP
//Autor: Ognjen Letic
//Datei: main.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main
//Änderungen:
//
//Box for the User Interface
//╔════════════════════╗ ╠ ╣ ╦ ╩ ╬
//║                    ║
//╚════════════════════╝
// ─ │ ┼ ┌ ┐ └ ┘ ├ ┤ ┬ ┴

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void Main(string[] args)
        {
            //central data
            int arraySize = 375;
            int[] day = new int[arraySize];
            byte[] humidity = new byte[arraySize];
            float[] temperature = new float[arraySize];
            ushort[] airPressure = new ushort[arraySize];

            int testSize = 0;

            #region test
            Random r = new Random();

            for (int count = 0; count < testSize; count++)
            {
                int rHumidity = r.Next(1, 100);
                int rTemperature = r.Next(-90, 60);
                int rAirPressure = r.Next(900, 1060);
                day[count] = count + 1;
                humidity[count] = Convert.ToByte(rHumidity);
                temperature[count] = rTemperature;
                airPressure[count] = Convert.ToUInt16(rAirPressure);
            }
            #endregion

            SplashScreen();

            Run(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
        }
    }
}
