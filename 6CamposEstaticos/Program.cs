Console.WriteLine("Campos Estáticos - Exercício");

ContaCorrente c1 = new();
c1.Conta = 101;
c1.Nome = "Maria";
//c1.Juros = 3.99f;

ContaCorrente c2 = new();
c2.Conta = 102;
c2.Nome = "Marta";
//c2.Juros = 4.99f;

ContaCorrente.Juros = 4.25f;



Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}