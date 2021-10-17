using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Principais Construtores
            DateTime d1 = new DateTime(2021, 10, 16);                 //(ano, mês, dia)
            DateTime d2 = new DateTime(2021, 10, 16, 22, 05, 3);      //(ano, mês, dia, hora, minuto, segundo)
            DateTime d3 = new DateTime(2021, 10, 16, 22, 05, 3, 500); //(ano, mês, dia, hora, minuto, segundo, milisegundo) PS os ms não aparecem.

            //Principais Builders
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine("|------------------------------|");
            Console.WriteLine("      " + d1);
            Console.WriteLine("      " + d2);
            Console.WriteLine("      " + d3);
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("      " + d4);
            Console.WriteLine("      " + d5);
            Console.WriteLine("      " + d6);
            Console.WriteLine("|------------------------------|");

            //Formatando o DateTime
            DateTime d7 = DateTime.Parse("2021-10-16");          //Passando o formato que eu quero.
            DateTime d8 = DateTime.Parse("2021-10-16 22:10:53"); //Passando o formato com hora.
            DateTime d9 = DateTime.Parse("16/10/2021");          //Passando o formato do Brasil.
            DateTime d10 = DateTime.Parse("16/10/2021 22:10:53");//Passando o formato do Brasil com Hora.

            Console.WriteLine("           Formatando          ");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("      " + d7);
            Console.WriteLine("      " + d8);
            Console.WriteLine("      " + d9);
            Console.WriteLine("      " + d10);
            Console.WriteLine("|------------------------------|");

            DateTime d11 = DateTime.ParseExact("2021-10-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("16/10/2021 22:32:41", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            
            Console.WriteLine("           ParseExact          ");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("      " + d11);
            Console.WriteLine("      " + d12);
            Console.WriteLine("|------------------------------|");
        }
    }
}
