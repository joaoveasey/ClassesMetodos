Console.WriteLine("Classes e Métodos\n");

//------instanciando os objetos p1 e p2 para a classe Pessoa--------
Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.nome = "Manoel";
p2.idade = 23;
p2.sexo = "masculino";

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Console.ReadLine();

//-----criando a classe Pessoa---------
class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}