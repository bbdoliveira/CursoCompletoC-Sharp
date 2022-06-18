using Course.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.00));
list.Add(new Product("HD Case", 80.00));

Func<Product, string> func = p => p.Name.ToUpper();

List<string> result = list.Select(func).ToList();
foreach (string s in result)
{
    Console.WriteLine(s);
}
