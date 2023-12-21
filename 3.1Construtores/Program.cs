Console.WriteLine("Construtores 2");

Aluno aluno = new Aluno("João", 18, "masc", "S");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "0" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadKey();

public class Aluno
{
    public Aluno(string nome) =>
        Nome = nome;
    
    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome) //--> esse comando le o construtor de cima
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}