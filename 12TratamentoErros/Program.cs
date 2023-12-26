Console.WriteLine("Divisão de números inteiros\n");
//sintaxe: 
//try
//{
//    //codigo que vai ser executado que pode gerar uma exceção
//}
//catch
//{
//    //se ocorrer um erro será tratado aqui
//}
//finally
//{
//    //codigo para liberar recursos, sera executado independente de ser lançado ou não uma exceção
//}

Console.WriteLine("x / y");

Console.WriteLine("Insira um valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira um valor de y");
int y = Convert.ToInt32(Console.ReadLine());


try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("Não existe divisão por 0, tente outro número");
    Console.WriteLine($"\nErro: <<< {ex.Message} >>>");
    Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("Processamento concluído...");
}

Console.ReadKey();