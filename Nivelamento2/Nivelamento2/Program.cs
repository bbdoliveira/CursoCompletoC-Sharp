using System;
using System.Globalization;

namespace Nivelamento2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, valorPi, areaCirculo;

            valorPi = 3.14159;

            raio = double.Parse(Console.ReadLine());

            areaCirculo = valorPi * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + areaCirculo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
