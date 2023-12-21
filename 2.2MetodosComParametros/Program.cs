Console.WriteLine("Métodos com parâmetros 2\n");

Aluno aluno1 = new Aluno();
aluno1.Consultar();

Console.ReadKey();


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Nome: ");
        aluno1.Nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        aluno1.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo: ");
        aluno1.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado? (S ou N) ");
        aluno1.Aprovado = Console.ReadLine().ToUpper();

        Curso curso = new Curso();
        curso.Resultado(aluno1);
    }
}

public class Curso
{
    public void Resultado(Aluno aluno1)
    {
        Console.WriteLine($"\nO aluno {aluno1.Nome}, com {aluno1.Idade} anos, do sexo {aluno1.Sexo}");
        if (aluno1.Aprovado == "S")
            Console.WriteLine("Foi aprovado!");
        else
            Console.WriteLine("Foi reprovado.");
    }
}