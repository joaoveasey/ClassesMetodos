// métodos anônimos com delegate

//Imprimir imprimir = delegate (int valor)
//{
//    Console.WriteLine($"Método anônimo. Valor: {valor}");
//};

//imprimir(100);

//Console.ReadKey();

//public delegate void Imprimir(int valor);


//----------------- OUTRO EXEMPLO -----------------

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("João");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificaNomeNaLista);

string resultadoComMetodoAnonimo = nomes.Find(delegate (string nome)
{
    return nome.Equals("Paulo");
});

//mesmo codigo acima porém usando expressão LAMBDA =>

string resultadoComLambda = nomes.Find(nome => nome.Equals("Paulo"));

//resultados

Console.WriteLine(resultadoComMetodoAnonimo);
Console.WriteLine(resultadoComLambda);

Console.ReadKey();

//static bool VerificaNomeNaLista(string nome)
//{
//    return nome.Equals("Paulo");
//}