using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Propriedades");

//é uma combinação de um campo provado e de dois acessadores: o get e o set

//sintaxe:
//public class Pessoa
//{
//    private string nome; //campo
//    public string Nome //propriedade
//    {
//        get { return nome; } //acessador get
//        set { nome = value; } //acessador set
//    }
//}

//==> sintaxe mais breve:
//public class Pessoa
//{
//    public string Nome { get; set; }   
//}

//------vantagens de usar propriedades:
//permitem um melhor controle dos membros da classe (reduzindo a possibilidade de bagunçar o código);
//os campos provados podem ser somente leitura (get) ou somente gravação (set);
//são mais flexíveis pois o programador pode alterar uma parte do código sem afetar outras partes
//garante uma maior segurança dos dados
//encapsulamento dos dados, ou seja o trabalho interno de uma classe deve ser escondido do mundo exterior

Produto p1 = new();
p1.Nome = "Caderno Espiral";
p1.Preco = 10.00;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();

public class Produto
{


    private string? nome;
    public string? Nome 
    {
        get { return nome.ToUpper(); } //utilizando as propriedades
        set { nome = value; } 
    }


    private double preco;
    public double Preco 
    {
        get { return preco; }
        set
        {
            if (value < 5.00) //nao permitindo setar nenhum preço menor que 5.
                preco = 5.00;
            else
                preco = value; 
        }
    }


    private double desconto = 0.05;
    public double Desconto 
    {
        get { return desconto; } //nao permitindo setar nenhum desconto, agora desconto possui o valor fixo de 0.05
    }


    public double PrecoFinal 
    {
        get { return Preco - (Preco * Desconto); } 
    }


    public int estoqueMinimo;
    public int EstoqueMinimo 
    {
        set { estoqueMinimo = value; } 
    }



    public void Exibir()
    {
        Console.WriteLine($"{Nome}\n{Preco.ToString("c")}\n{Desconto}\n" +
                            $"{PrecoFinal.ToString("c")}\n{estoqueMinimo}");
    }
}