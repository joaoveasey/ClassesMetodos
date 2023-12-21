Console.WriteLine("This");

//Teste t1 = new Teste();
//t1.Num1 = 1;
//t1.Num2 = 2;
//t1.Exibir();

//Teste t2 = new Teste();
//t2.Num1 = 20;
//t2.Num2 = 30;
//t2.Exibir();

Teste novoTeste = new Teste(999);

Console.ReadKey();

//public class Cliente
//{
//    public string? Nome;
//    public int Idade;

//    public Cliente (string Nome, int Idade)
//    {
//        this.Nome = Nome;
//        this.Idade = Idade; // a palavra this referencia a classe Cliente
//    }
//}

//---------usando o this para passar um objeto da instância como parâmetro de outros métodos------------

//public class Teste
//{
//    public int Num1;
//    public int Num2;
//    public void PassarParametro(Teste t)
//    {
//        Console.WriteLine($"\nthis = {this}");
//        Console.WriteLine("Num1 =" + Num1);
//        Console.WriteLine("Num2 =" + Num2);
//    }
//    public void Exibir()
//    {
//        //passando o this como um parâmetro (a classe Teste)
//        PassarParametro(this);
//    }
//}

//--------usando this para invocar outro construtor da mesma classe----------------
 
public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine("Construtor com 2 parâmetros: " + num1 +" e "+ num2);
    }
    public Teste(int num) : this(777,888)
    {
        Console.WriteLine("Construtor com um parâmetro: "+ num);
    }
}