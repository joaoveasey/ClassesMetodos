Console.WriteLine("Tipos Anônimos");

//propriedades somente leitura
//nao suportam metodos, eventos, apenas propriedades.

var aluno = new
{
    Nome = "Maria",
    Idade = 43,
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil"}
};

Console.WriteLine($"{aluno.Nome} - {aluno.Idade} anos, {aluno.Endereco.Cidade}");

Console.ReadKey();