using System;
using System.Globalization;

namespace ExercicioFix_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            double area = r.Area();
            double perimetro = r.Perimetro();
            double diagonal = r.Diagonal();

            Console.WriteLine("AREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
