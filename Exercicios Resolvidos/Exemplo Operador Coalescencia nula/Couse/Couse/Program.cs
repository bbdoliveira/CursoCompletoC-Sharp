using System;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            //Usando este operador, caso o valor de X seja null ele vai usar o valor a direita.
            double a = x ?? 5; 
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
