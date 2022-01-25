using Course.Entities;

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

Console.WriteLine(a.Equals(b)); //Equals compara o conteudo das variáveis.
Console.WriteLine(a == b);      //O operador == comprar a referencia do ponteiro de memoria.
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
