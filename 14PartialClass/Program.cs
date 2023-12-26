using _14PartialClass;

Console.WriteLine("Partial Class\n");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

var idade = minhaPartialClass.CalculaIdade(new DateTime(2005, 2, 4));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.ReadKey();