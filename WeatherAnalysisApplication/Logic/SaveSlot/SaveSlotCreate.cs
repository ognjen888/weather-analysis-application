//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveSlotCreate.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void SaveSlotCreate(string fileName, int[] day, byte[] humidity, float[] temperature, ushort[] airPressure, int arraySize, bool encrypt = false)
        {
            CalculateDataAverage(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);

            StreamWriter writer = new StreamWriter($"{fileName}");

            if (encrypt == true)
            {
                // WeatherAnalysisApplication\bin\Debug
                writer.WriteLine(EncryptThisStringCeaser("days;humidityAverage;temperatureAverage;airPressureAverage"));
                writer.WriteLine(EncryptThisStringCeaser($"{day[367]};{humidity[367]};{temperature[367]};{airPressure[367]}"));
                writer.WriteLine("");
                writer.WriteLine(EncryptThisStringCeaser("day;humidity;temperature;airPressure"));

                for (int count = 0; count < 365; count++)
                {
                    if(airPressure[count] != 0)
                    {
                        writer.WriteLine(EncryptThisStringCeaser($"{day[count]};{humidity[count]};{temperature[count]};{airPressure[count]}"));
                    }
                }
            }
            else
            {
                // WeatherAnalysisApplication\bin\Debug
                writer.WriteLine("days;humidityAverage;temperatureAverage;airPressureAverage");
                writer.WriteLine($"{day[367]};{humidity[367]};{temperature[367]};{airPressure[367]}");
                writer.WriteLine("");
                writer.WriteLine("day;humidity;temperature;airPressure");

                for (int count = 0; count < 365; count++)
                {
                    if(airPressure[count] != 0)
                    {
                        writer.WriteLine($"{day[count]};{humidity[count]};{temperature[count]};{airPressure[count]}");
                    }
                }
            }

            writer.Close();
        }
    }
}
