Console.WriteLine("Structs");
//struct é semelhante a uma classe. sua diferença é que as structs são tipos de valor (criadas na memória stack)
//ou seja são "classes mais leves"
//podemos conter campos, métodos, constantes, construtores, propriedades, indexadores, operadores e ate outros tipos de estruturas.
//criar struct quando as instâncias forem pequenas e com curta duração

//CUIDADO: 
//criar uma struct apenas sobre essas condições:
//tem tamanho de instância menor que 16 bytes
//é imutável
//não precisará sofrer conversão para tipo de referência (boxing) com frequência


//sintaxe: 
//struct <nome_do_tipo>
//{
//    //membros: campos, propds, metodos, construtor, etc..
//}

Console.ReadKey();

public struct Cliente
{
    public string? Nome {  get; set; }  
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}