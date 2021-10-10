using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Usando o método Add(), insere elementos na lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Boby");
            list.Add("Anna");

            //Usando o método Insert(), para inserir elementos na lista passando alguma posição.
            list.Insert(2, "Marco");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------");
            //Usando método Count(), para saber o tamanho da lista.
            Console.WriteLine("Lista count: " + list.Count);
            Console.WriteLine("---------------------------------");

            //Usando o método Find(), para encontrar elementos na lista (que satisfaça um predicado).
            string s1 = list.Find(x => x[0] == 'A' || x[3] == 'a');
            Console.WriteLine("First 'A': " + s1);
            Console.WriteLine("---------------------------------");

            //Usando o método FindLast(). para encontrar o ultimo elemento da lista (que satisfaça um predicado).
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);
            Console.WriteLine("---------------------------------");

            //Usando o método FindIndex(), para encontrar a primeira posição do elemento (que staisfaça um predicado);
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First positiona 'A': " + pos1);
            Console.WriteLine("---------------------------------");

            //Usando o método FindLastIndex(), para encontraro o ultimo elemento (que satisfaça um predicado);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last index 'A': " + pos2);
            Console.WriteLine("---------------------------------");

            //Usando o método FindAll(), para encontrar os elementos com base no predicado.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Listando os elementos que tenham tamanho 5:");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            //Usando o método Remove(), pra remover elemetos da lista
            list.Remove("Alex");
            Console.WriteLine("Removendo o nome Alex da lista: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            //Usando o método RemoveAll(), para remover todos os elementos (que satisfaçam um predicado).
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("Removendo todo os nomes que começam com M: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Boby");
            list.Add("Anna");

            //Usando o método RemoveAt, para remover um item da lista indicado pelo index.
            list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            //Usando o método RemoveRange indicado pelo index e a quantidade de elementos.
            list.RemoveRange(2, 2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
