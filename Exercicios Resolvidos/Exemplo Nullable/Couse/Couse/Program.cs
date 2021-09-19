using System;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; //Defime uma variavel como Nullable de double usando o '?'.
            double? y = 10.0;

            //Metodo GetValueOrDeafault(), pega o valor que tiver ou então o valor padrão do tipo.
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Método HasValue() verifica se tem ou não Valor retornando um booleano (True or False)
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Método Value() retorna o valor da váriavel, porém se o valor for null é preciso tratar o erro
            //pois ela não vai imprimir null.
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
        }
    }
}
