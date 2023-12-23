Console.WriteLine("Métodos Estáticos");
//os métodos estáticos pertencem a CLASSE e NÃO a um OBJETO
//ou seja não precisa instanciar um objeto para acessá-los
//abaixo um exemplo de acesso usando a sintaxe  ==> Classe.Método();

Console.WriteLine(Calculadora.Somar(10, 10));
Console.WriteLine(Calculadora.Subtrair(10, 10));
Console.WriteLine(Calculadora.Multiplicar(10, 10));
Console.WriteLine(Calculadora.Dividir(10, 10));

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}