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

Console.WriteLine("Exercício 1\n");

//Carro chevrolet = new Carro();

//chevrolet.modelo = "Sedan";
//chevrolet.montadora = "Chevrolet";
//chevrolet.marca = "Onix";
//chevrolet.ano = 2016;
//chevrolet.potencia = 110;

//Carro ford = new Carro();

//ford.modelo = "SUV";
//ford.montadora = "Ford";
//ford.marca = "EcoSport";
//ford.ano = 2018;
//ford.potencia = 120;

//Console.WriteLine($"Carro Ford\n\nModelo: {ford.modelo}\nMontadora: {ford.montadora}\nMarca: {ford.marca}\nAno: {ford.ano}\nPotência: {ford.potencia}\n");
//ford.Acelerar();

//Console.WriteLine("-----------------------------\n");

//Console.WriteLine($"Carro Chevrolet\n\nModelo: {chevrolet.modelo}\nMontadora: {chevrolet.montadora}\nMarca: {chevrolet.marca}\nAno: {chevrolet.ano}\nPotência: {chevrolet.potencia}\n");
//chevrolet.Acelerar();

Carro carro1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro carro2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.ReadKey();

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
        Acelerar();
    }

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {marca}.... vrummmmmmmmmm\n");
    }

}