using System;
using System.Globalization;

namespace System
{
    class Program
    {
        static void Main()
        {
            //Localization Data
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            //Input and conversion
            string input = Console.ReadLine();
            double[] sides = { double.Parse(input.Split(";")[0].Trim()), double.Parse(input.Split(";")[1].Trim()), double.Parse(input.Split(";")[2].Trim()) };
            Array.Sort(sides); //from smallest to biggest

            //Check for incorrect data
            if (sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
            {
                Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                return;
            }
            if (sides[0] + sides[1] < sides[2])
            {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                return;
            }

            //OBWÓD
            Console.WriteLine($"obwód = {String.Format("{0:0.00}", sides[0] + sides[1] + sides[2])}");

            //POLE
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            double result = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            Console.WriteLine($"pole = {String.Format("{0:0.00}", result)}");

            //KĄTY
            if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
                Console.WriteLine("trójkąt jest prostokątny");
            else if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) > Math.Pow(sides[2], 2))
                Console.WriteLine("trójkąt jest ostrokątny");
            else if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) < Math.Pow(sides[2], 2))
                Console.WriteLine("trójkąt jest rozwartokątny");

            //WYMIARY
            if (sides[0] == sides[1] && sides[1] == sides[2])
                Console.WriteLine("trójkąt równoboczny");
            else if (sides[0] == sides[1] || sides[1] == sides[2])
                Console.WriteLine("trójkąt równoramienny");
        }
    }
}
