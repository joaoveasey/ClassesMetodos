Console.WriteLine("Métodos com retorno");

Calculadora calc = new Calculadora();
var valorSoma = calc.Somar(10,10);
Console.WriteLine(valorSoma);
//ou
Console.WriteLine(calc.Somar(10,10));


Console.ReadLine();

public class Calculadora
{
    public int Somar (int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}