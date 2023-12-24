Console.WriteLine("Construtor Estático");
//construtor estático é executado apenas uma vez

//invoca o parametrizado e o estático
Pessoa p1 = new(19, "Maria");
Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);

//invoca apenas o parametrizado
Pessoa p2 = new(29, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Mínima " + Pessoa.IdadeMinima);

Console.ReadKey();
