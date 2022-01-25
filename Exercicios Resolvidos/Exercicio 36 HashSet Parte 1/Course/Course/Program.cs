HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

if (set.Contains("Tablet") == true) //Verifica se existe o valor no conjunto.
{
    Console.WriteLine("Mas é claro!");
}

foreach (string item in set) //Imprime o conjunto linha a linha.
{
    Console.WriteLine(item);
}
