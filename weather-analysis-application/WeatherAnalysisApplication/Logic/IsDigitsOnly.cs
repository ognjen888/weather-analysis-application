//Name: WAP
//Autor: Ognjen Letic
//Datei: IsDigitsOnly.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static bool IsDigitsOnly(string thisString, int length = 10)
        {
            // local
            int counter = 0;
            int thisStringLength = 0;

            if (thisString == "" || thisString == "-") // checks if thisString is empty or if thisString only has "-".
            {
                return false;
            }

            foreach (char c in thisString)
            {
                thisStringLength = thisStringLength + 1;
            }

            if (thisString[0] == '-') // for negative numbers, if thisString = "-100"; then for loop starts from "100" instead "-100" which would result in return false.
            {
                counter = 1;
            }

            for (counter = counter; counter < thisStringLength; counter++)
            {
                char c = thisString[counter];

                if (c < '0' || c > '9')
                {
                    return false;
                }
                else if (counter > length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
