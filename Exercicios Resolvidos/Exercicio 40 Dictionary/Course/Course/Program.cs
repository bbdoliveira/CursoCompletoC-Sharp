Dictionary<string, string> cookies = new Dictionary<string, string>(); //Instaciando um Dictionary.

string borda = "---------------------------------------------------|";

Console.Write("Quantos cookies serão? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) //Faz a inserção de valores no Dictionary
{
    Console.Write("Digite a chave: ");
    string key = Console.ReadLine();
    Console.Write("Digite o valor: ");
    string value = Console.ReadLine();
    cookies[key] = value;
}

Console.WriteLine(borda);
Console.WriteLine("Agora sua lista ficou assim: "); //Mostra o Dictionary como ficou.
Console.WriteLine();
foreach (var item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}

Console.WriteLine(borda);
Console.WriteLine();
Console.Write("Gostaria de remover alguma chave? (s/n) ");
char option = char.Parse(Console.ReadLine());
if (option == 's')
{
    Console.Write("Digite a chave a ser removida: ");
    string keyToRemove = Console.ReadLine();
    cookies.Remove(keyToRemove);

    Console.WriteLine(borda);
    Console.WriteLine();
    Console.WriteLine("Agora sua lista ficou assim: ");
    foreach (KeyValuePair<string, string> item in cookies) //Pode ser usado o var no lugar de 'KeyValuePair<string, string>'.
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
    Console.WriteLine();
    Console.WriteLine(borda);
}
else
{
    Console.WriteLine("Obrigado!");
    Console.WriteLine();
    Console.WriteLine(borda);
}
