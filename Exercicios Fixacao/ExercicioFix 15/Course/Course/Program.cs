Dictionary<string, int> votes = new Dictionary<string, int>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int qtdVotes = int.Parse(line[1]);
            if (votes.ContainsKey(name))
            {
                votes[name] = votes[name] + qtdVotes;
            }
            else
            {
                votes.Add(name, qtdVotes);
            }
        }
        foreach (var item in votes)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
