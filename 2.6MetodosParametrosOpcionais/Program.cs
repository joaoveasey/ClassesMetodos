Console.WriteLine("Parâmetros Opcionais");

Console.WriteLine("Informe o destino");
var destino = Console.ReadLine();

Console.WriteLine("Informe o título");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo = "Título Padrão", string assunto = "Assunto Padrão") //--> neste caso destino é obrigatorio, enquanto titulo e assunto são opcionais
    {
        Console.WriteLine($"\nPara {destino} - {titulo}\nAssunto: {assunto}");
    }
}