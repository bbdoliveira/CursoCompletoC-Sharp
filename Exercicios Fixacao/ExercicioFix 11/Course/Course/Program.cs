using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double teste = 200.00;
            string imprima = teste.ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine(imprima);
        }
    }
}
