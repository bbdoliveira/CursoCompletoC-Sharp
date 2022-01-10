// See https://aka.ms/new-console-template for more information

Console.Write("Enter file full path (Ex: C:NomeDoArquivo.csv): ");
string sourceFilePath = Console.ReadLine();

try
{
    string[] lines = File.ReadAllLines(sourceFilePath);

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";

    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (string line in lines)
        {
            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], System.Globalization.NumberStyles.Currency);
            int quantity = int.Parse(fields[2]);

            Course.Entities.Product prod = new Course.Entities.Product(name, price, quantity);

            sw.WriteLine(prod.Name + ", " + prod.Total());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred!");
    Console.WriteLine(e.Message);
}