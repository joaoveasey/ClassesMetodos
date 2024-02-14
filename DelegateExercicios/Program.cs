var listaDePessoas = Pessoa.GetPessoas();

//1) percorrer a lista e imprimir nome e idade de cada uma.

Action<Pessoa> imprimirNome = p => Console.WriteLine(p.Nome + " " + p.Idade);

listaDePessoas.ForEach(imprimirNome);

//2) filtrar a idade das pessoas, retornando apenas aquelas que possuem idade maior que 18 anos.

Predicate<Pessoa> filtrarIdadeMaiorQue18 = p => p.Idade > 18;

var pessoasMaiores18 = listaDePessoas.FindAll(filtrarIdadeMaiorQue18);

pessoasMaiores18.ForEach(imprimirNome);

//3) obter nome e idade da pessoa mais velha da lista.

Func<Pessoa, int> obterIdade = p => p.Idade;

var PessoaMaisVelha = listaDePessoas.MaxBy(obterIdade);

Console.ReadKey();

public class Pessoa
{
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public string? Nome { get; set;}
    public int Idade { get; set;}
    public static List<Pessoa> GetPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa("João",20),
            new Pessoa("Maria",18),
            new Pessoa("Pedro",25),
            new Pessoa("Carlos",15),
            new Pessoa("Ana", 17),
        };
        return pessoas;
    }
}