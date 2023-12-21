Console.WriteLine("Construtores\n");


Console.ReadKey();

//-------------construtor sem parametros----------

//Aluno aluno = new Aluno(); //--> nao preciso passar os parametros
//operador ternario para verificar os valores padrões
//Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
//Console.WriteLine(aluno.Idade == 0 ? "0" : aluno.Idade);
//Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
//Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

//Console.ReadKey();

//public class Aluno
//{
//    public Aluno(); --> construtor
//    public string? Nome;
//    public int Idade;
//    public string? Sexo;
//    public string? Aprovado;
//}

//-------------construtor com parâmetros----------

Aluno aluno = new Aluno("João", 18, "Masculino", "S"); //--> preciso passar os parâmetros 

public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado) //--> construtor com parâmetros
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;   
    }
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}