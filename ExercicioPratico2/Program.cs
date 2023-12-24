Console.WriteLine("Exercício Prático 2\n");

//a diferença entre uma struct e uma classe está no local da memória em que os dados são alocados, sendo a struct alocado na memória stack e as classes
//na memória heap, fazendo com que as structs acabem tendo quase as mesmas funcionalidades de uma classe, sendo uma alternativa mais leve.

Cliente cliente = new("João", "joao@gmail.com", 18);

Cliente.ExibirInfo("João", "joao@gmail.com", 18);
Cliente.ExibirInfo("João", "joao@gmail.com"); //=> sem informar o ano

Console.ReadKey();

public struct Cliente //stack overflow !!!!
{
    public string? Nome {  get; set; }
    public string? Email { get; set; }
    public int Idade 
    { 
        get 
        { return Idade; } 
        set 
        { 
            if(Idade < 18)
            {
                Idade = 18;
            }
            Idade = value; 
        } 
    }

    public Cliente(string? nome, string? email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string? nome, string? email, int idade = 18) //--> idade é um parâmetro opcional
    {
        Console.WriteLine($"{nome}\n{email}\n{idade}");
    }
}