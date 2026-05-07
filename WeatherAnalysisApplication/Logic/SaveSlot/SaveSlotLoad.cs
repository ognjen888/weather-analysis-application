//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveSlotLoad.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void SaveSlotLoad(string selectedSlot, ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, int arraySize)
        {
            // local
            string[] parts = new string[0];
            string line = null;
            int position = 0;

            if (!File.Exists(selectedSlot))
            {
                return;
            }

            ClearData(ref day, ref humidity, ref temperature, ref airPressure, arraySize);

            StreamReader reader = new StreamReader(selectedSlot);

            line = reader.ReadLine();

            if (line == null)
            {
                return;
            }

            if (line == "days;humidityAverage;temperatureAverage;airPressureAverage")
            {
                line = reader.ReadLine();
                parts = line.Split(';');

                day[367] = int.Parse(parts[0]);
                humidity[367] = byte.Parse(parts[1]);
                temperature[367] = float.Parse(parts[2]);
                airPressure[367] = ushort.Parse(parts[3]);

                reader.ReadLine();
                reader.ReadLine();

                for (int count = 0; count <= 365; count++)
                {
                    line = reader.ReadLine();

                    if (line != null)
                    {
                        parts = line.Split(';');
                        position = int.Parse(parts[0]) - 1;

                        day[position] = int.Parse(parts[0]);
                        humidity[position] = byte.Parse(parts[1]);
                        temperature[position] = float.Parse(parts[2]);
                        airPressure[position] = ushort.Parse(parts[3]);
                    }
                }
            }
            else
            {
                line = reader.ReadLine();
                line = DecryptThisStringCeaser(line);
                parts = line.Split(';');

                day[367] = int.Parse(parts[0]);
                humidity[367] = byte.Parse(parts[1]);
                temperature[367] = float.Parse(parts[2]);
                airPressure[367] = ushort.Parse(parts[3]);

                reader.ReadLine();
                reader.ReadLine();

                for (int count = 0; count <= 365; count++)
                {
                    line = reader.ReadLine();

                    if (line != null)
                    {
                        line = DecryptThisStringCeaser(line);
                        parts = line.Split(';');
                        position = int.Parse(parts[0]) - 1;

                        day[position] = int.Parse(parts[0]);
                        humidity[position] = byte.Parse(parts[1]);
                        temperature[position] = float.Parse(parts[2]);
                        airPressure[position] = ushort.Parse(parts[3]);
                    }
                }
            }

            reader.Close();

            Message("Succesfully loaded data.");
        }
    }
}
