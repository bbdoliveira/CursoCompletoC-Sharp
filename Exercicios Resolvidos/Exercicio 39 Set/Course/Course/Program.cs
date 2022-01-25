using Course.Entities;

HashSet<LogRecord> records = new HashSet<LogRecord>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime dateTime = DateTime.Parse(line[1]);
            records.Add(new LogRecord { Username = name, Instant = dateTime});
        }
        Console.WriteLine("Total users: " + records.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
