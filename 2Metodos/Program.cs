Console.WriteLine("Métodos\n");

MinhaClasse minhaClasse = new MinhaClasse(); //criação do objeto

minhaClasse.Saudacao(); //invocando o método

Console.ReadKey();

//-------sintaxe mínima------
// tipo de retorno (void, string, int, etc)
// nome (Pascal Case)
// lista de parâmetros (tipos de dados e o valor das variáveis/objetos
// corpo do método

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Seja Bem-vindo");
        ExibirDataAtual();
    }

    //forma + compacta de definir um método (só pode ser feito quando há uma instrução)
    public void ExibirDataAtual() =>
        Console.WriteLine(DateTime.Now.ToShortDateString());
    
}