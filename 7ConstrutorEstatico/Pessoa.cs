

public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set;}
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Idade = idade;
        Nome = nome;
    }
    public Pessoa() { }

    //static Pessoa()
    //{
    //    Console.WriteLine("\nExecutando o construtor estático");
    //    Console.WriteLine("\nInicializando o campo IdadeMinima");
    //    IdadeMinima = 18;
    //}
}