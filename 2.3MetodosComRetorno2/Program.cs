Console.WriteLine("Assinatura de Método - Sobrecarga");

Email email = new Email();
email.Enviar("Rua Antonio"); //usando a primeira sobrecarga
email.Enviar("Rua Antonio", "Procuro emprego"); //usando a segunda sobrecarga
email.Enviar("Rua Antonio", 2000); //usando a terceira sobrecarga
email.Enviar(200, "Rua Antonio"); //usando a quarta sobrecarga

Console.ReadKey();

public class Email
{
    //primeira sobrecarga
    public void Enviar (string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão");
    }
    //segunda sobrecarga
    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }
    //terceira sobrecarga
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine($"{valor}");
    }
    //quarta sobrecarga
    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine($"{valor}");
    }
}