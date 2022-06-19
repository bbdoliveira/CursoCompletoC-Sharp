using System.Globalization;
using Course.Entities;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

List<Product> list = new List<Product>();

// Fazer a leitura do arquivo.
using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        list.Add(new Product(name, price));
    }

    // Pega os itens da lista pelo preço e faz a média.
    var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

    // Pega os itens com valor menor a Média e ordena de forma decrescente.
    var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}
