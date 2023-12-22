//1) Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
//potencia com os tipos de dados string, string, string, int e int.
//Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”
//c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
//para cada objeto
//a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet, Onix, 2016, 110
//d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
//mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.
//b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120
//e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
//modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)
//f - Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
//método Acelerar passando o valor do argumento para o parâmetro no método Acelerar
//Obs- Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os
//membros da classe
//g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
//use a palavra-chave this)
//i - Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
//vai retornar um double representando a velocidade máxima do carro
//( Para calcular a velocidade multiplique a potencia por 1.75)
//h - Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
//j- Explique o comportamento da palavra return


Console.WriteLine("Exercício 1\n");

Carro chevrolet = new Carro("Sedan", "Chevrolet");

chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;

//Console.WriteLine(chevrolet.VelocidadeMaxima(chevrolet.Potencia));


Carro ford = new Carro("SUV", "Ford");

ford.Marca = "EcoSport";
ford.Ano = 2018;
ford.Potencia = 120;

//Console.WriteLine(ford.VelocidadeMaxima(ford.Potencia));


//Console.WriteLine($"Carro Ford\n\nModelo: {ford.modelo}\nMontadora: {ford.montadora}\nMarca: {ford.marca}\nAno: {ford.ano}\nPotência: {ford.potencia}\n");
//ford.Acelerar();

//Console.WriteLine("-----------------------------\n");

//Console.WriteLine($"Carro Chevrolet\n\nModelo: {chevrolet.modelo}\nMontadora: {chevrolet.montadora}\nMarca: {chevrolet.marca}\nAno: {chevrolet.ano}\nPotência: {chevrolet.potencia}\n");
//chevrolet.Acelerar();

//Carro carro1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
//Carro carro2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

//ford.AumentarPotencia(ford.Potencia);
//Console.WriteLine(ford.Potencia);
//nesse caso acima o valor mostrado continua 120, pois o argumento foi por valor, ou seja nao afeta o valor original

ford.AumentarPotencia(ref ford.Potencia);
Console.WriteLine(ford.Potencia);
//nesse caso acima o valor mostra 125, pois o argumento foi por referência (ref), ou seja, irão se referenciar ao mesmo espaço da memória (obtendo o mesmo valor)

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora)
    {
        Montadora = montadora;
        Modelo = modelo; //ao atribuir esse construtor os atributos Marca, Ano, Potencia receberão seus valores padrão (0 ou null)
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
    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {Marca}.... vrummmmmmmmmm\n");
    }

}