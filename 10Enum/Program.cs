using _10Enum;

Console.WriteLine("Enum\n");
//enum é um tipo de dado especial definido pelo usuário 
//é definido por um conjunto de constantes nomeadas do tipo numérico
//seu uso facilita a leitura e o mantimento do programa 
//sintaxe:
//enum DiasDaSemana : (definição do tipo) ==> só pode ser tipo numérico
//{
//    Segunda = 0 ,  ==> também posso atribuir valores
//    Terça,    //1
//    Quarta,    //2
//    Quinta,    //3
//    Sexta,    //4
//    Sabado,   //5
//    Domingo   //6
//}

//Console.WriteLine(DiasDaSemana.Domingo);
//Console.WriteLine(DiasDaSemana.Terça);

//int dia1 = (int)DiasDaSemana.Domingo;
//int dia2 = (int)DiasDaSemana.Terça;

//Console.WriteLine(dia1);
//Console.WriteLine(dia2);

Console.WriteLine($"\n{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livro} - {(int)Categorias.Livro}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine("Selecione a categoria teclando seu valor: ");
int valor = Convert.ToInt32(Console.ReadLine());


var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\nVocê selecionou a categoria: {nomeMembroEnum.ToString()}");


Console.ReadKey();


