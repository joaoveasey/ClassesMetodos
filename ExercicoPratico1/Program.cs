using ExercicoPratico1;
//1) exercicios relacionados a classes e metodos


Console.WriteLine("Exercício 1\n");

//Carro chevrolet = new Carro("Sedan", "Chevrolet");

//chevrolet.Marca = "Onix";
//chevrolet.Ano = 2016;
//chevrolet.Potencia = 110;

//Console.WriteLine(chevrolet.VelocidadeMaxima(chevrolet.Potencia));


//Carro ford = new Carro("SUV", "Ford");

//ford.Marca = "EcoSport";
//ford.Ano = 2018;
//ford.Potencia = 120;

//Console.WriteLine(ford.VelocidadeMaxima(ford.Potencia));


//Console.WriteLine($"Carro Ford\n\nModelo: {ford.modelo}\nMontadora: {ford.montadora}\nMarca: {ford.marca}\nAno: {ford.ano}\nPotência: {ford.potencia}\n");
//ford.Acelerar();

//Console.WriteLine("-----------------------------\n");

//Console.WriteLine($"Carro Chevrolet\n\nModelo: {chevrolet.modelo}\nMontadora: {chevrolet.montadora}\nMarca: {chevrolet.marca}\nAno: {chevrolet.ano}\nPotência: {chevrolet.potencia}\n");
//chevrolet.Acelerar();

//carro carro1 = new carro("sedan", "chevrolet", "onix", 2016, 110);
//carro carro2 = new carro("suv", "ford", "ecosport", 2018, 120);

//ford.AumentarPotencia(ford.Potencia);
//Console.WriteLine(ford.Potencia);
//nesse caso acima o valor mostrado continua 120, pois o argumento foi por valor, ou seja nao afeta o valor original

//ford.AumentarPotencia(ref ford.Potencia);
//Console.WriteLine(ford.Potencia);
//nesse caso acima o valor mostra 125, pois o argumento foi por referência (ref), ou seja, irão se referenciar ao mesmo espaço da memória (obtendo o mesmo valor)

//uso do out --> faz com que possamos retornar dois resultados de um mesmo metodo, neste caso retorno a potencia e a velocidade
//Carro carro1 = new();
//carro1.Potencia = 200;

//double aumentoPotencia = carro1.AumentarPotenciaVelocidade(carro1.Potencia, out double velocidade);
//Console.WriteLine($"Potência: {aumentoPotencia}cv\nVelocidade máxima: {velocidade} km/h");

//uso dos argumentos nomeados e parâmetros opcionais
//os parâmetros opcionais: servem para você omitir algum parâmetro, devem ser definidos depois da definição dos parâmetros normais
//argumentos nomeados: permitem que você especifique um argumento, ao invés de passar em sua ordem na lista de parâmetros
Carro volvo = new();

//volvo.ExibirInfo(modelo: "SUV", montadora: "Volvo", marca: "XC60", potencia: 150);//primeiro sem informar o ano, sendo recebido o valor nomeado no parâmetro do método

//volvo.ExibirInfo(modelo: "SUV", montadora: "Volvo", marca: "XC60", potencia: 150, ano: "2023");

//O modificador static permite declarar um membro estático que pertence ao próprio tipo e não a um objeto específico.Ele pode ser usado para
//declarar classes, structs e interfaces.
//Carro.ObterValorIpva();
//Console.WriteLine($"Valor do campo ValorIpva: {Carro.ValorIpva} %");

//A diferença de propriedade e campo está na forma como podemos encapsular os dados com as propriedades, limitando as ações dele, assim evitando erros nos dados
//ford.Ano = 2023;
//Console.WriteLine(ford.Ano);

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("Selecione a cor teclando seu valor: ");
int cor = Convert.ToInt32(Console.ReadLine());

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);

chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca, chevrolet.Potencia, chevrolet.Cor);

Console.ReadKey();



public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Potencia;
    public int Cor;
    private int ano;
    public int Ano 
    {
        get { return ano; }
        set 
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        } 
    }

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        Montadora = montadora;
        Modelo = modelo; //ao atribuir esse construtor os atributos Marca, Ano, Potencia receberão seus valores padrão (0 ou null)
        Marca = marca;
        Cor = cor;
        Ano = ano;
        Potencia = potencia;
    }
    public Carro()
    {
        
    }
    public static double ValorIpva;
    public static void ObterValorIpva()
    {
        ValorIpva = 4;
    }
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Cor = 1)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
        Console.WriteLine((Cores)Cor);
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75; //"return" retorno um tipo de dado, nesse caso um double, e encerra o método.
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }
    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = potencia * 1.75;      
        return potencia += 7;
    }
    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {Marca}.... vrummmmmmmmmm\n");
    }

}