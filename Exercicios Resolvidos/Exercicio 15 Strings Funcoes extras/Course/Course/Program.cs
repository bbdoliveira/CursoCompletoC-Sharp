using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper(); //ToUpper() deixa tudo maiúsculo.
            string s2 = original.ToLower(); //ToLower() deixa tudo minúsculo.
            string s3 = original.Trim();    //Trim() remove espaços em branco no final da string.

            int n1 = original.IndexOf("bc");    //IndexOf() Encontra primeira ocorrência do parâmetro passado.
            int n2 = original.LastIndexOf("bc");//LastIndexOf() Encontra a ultima ocorrência do parâmetro passado.

            string s4 = original.Substring(3);     //Eliminta tudo antes da posição do parâmetro.
            string s5 = original.Substring(3, 5);  //Começa a partir do primeiro parâmetro, com o tamanho máximo do segundo.

            string s6 = original.Replace('a', 'x');    //Troca o conteudo do primeiro parâmetro pelo segundo.
            string s7 = original.Replace("abc", "xy"); //Troca a primeira string pela segunda.

            bool b1 = String.IsNullOrEmpty(original); //Verifica se o conteudo da string é nulo ou vazio;
            bool b2 = String.IsNullOrWhiteSpace(original); //Verifica se o conteudo da string é nulo ou são espaços em branco;

            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            Console.WriteLine("|-----------------------------------------------------|");
        }
    }
}
