Console.WriteLine("Argumentos nomeados");

Email email = new Email();

//sem nomear os argumentos

email.Enviar("teste@gmail.com", "Urgente", "Reunião");

//usando argumentos nomeados (posso escrever em qualquer ordem)

email.Enviar(titulo: "Urgente", destino: "teste@gmail.com", assunto: "Reunião");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo}\nAssunto: {assunto}");
    }
}