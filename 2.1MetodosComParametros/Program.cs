Console.WriteLine("Métodos com parâmetros");


MinhaClasse minhaClasse = new MinhaClasse();

//valores dos argumentos
minhaClasse.Saudacao("João",DateTime.Now.ToShortDateString());


Console.ReadKey();

public class MinhaClasse
{
    //parametros do metodo
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}

