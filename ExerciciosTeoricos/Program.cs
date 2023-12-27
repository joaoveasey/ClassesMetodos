Console.WriteLine("Exercícios Teóricos");

//1- O que é uma classe e qual a sua composição ?
//Uma classe é a definição de um novo tipo, podendo ser composta por propriedades, métodos e objetos.

//2- O que é um objeto e como pode ser criado ?
//Um objeto é a tentativa de representar algo do mundo real a partir de métodos e propriedades, podem ser criados com o codigo "NomeDaClasse nomeObjeto = new ();"

//3- Qual a diferença entre classe e objeto ?
//classe é mais amplo e consegue criar diferentes objetos com o mesmo tipo, com a mesma classe. por exemplo, a classe Carro, ela pode instanciar objetos como, Volvo, Fiat, Chevrolet, etc.

//4- O que é um método e como pode ser criado e chamado ?
//método é uma ação que os objetos podem ou não executar, podendo ser criada com o código: MeuMetodo(parametros){   }, e ser chamado com o código: nomeDoObjeto.MeuMetodo();                  

//5- O que é um parâmetro de método ?
//parâmetros são dados que vão ser usados no método, por exemplo, se eu criar um método AcelerarCarro(int velocidade), quando eu quiser que um objeto execute esse método, precisarei passar o parâmetro int velocidade.

//6- O que é um argumento ?
//é o valor que podemos ou não passar a um parâmetro, assim, se não houver o valor de um parâmetro, ao invés de passarmos seu valor padrão, passamos o argumento.

//7- O que é um construtor e qual o seu objetivo ?
//construtores são tipos especiais de métodos usados para instanciar e inicializar objetos, a partir dele, podemos instanciar membros de uma classe.

//8- Quais os usos da palavra chave this ?
//a palavra this pode ser usado para referenciar uma classe, this.AtributoClasse; também para passar um objeto da instância como parâmetro de outros métodos

//9- O que é um método com retorno ?
//quando o método não é void, ele retorna algum valor, podendo ser string, double, int, etc.

//10- O que é sobrecarga de método ?
//é quando criamos métodos sobrepostos com propriedades diferentes, para serem usados de acordo com as propriedades que foram passados.

//11- Como é feita a passagem de parâmetros por valor ?
//é criada uma cópia da variável, sendo assim o valor da original não muda após passar pelo método

//12- Como é feita a passagem de parâmetros por referência ?
//ao passar o parâmetro do método, usamos a palavra ref, ficando com a seguinte sintaxe: meuObjeto.Metodo(ref x), fazendo com que o valor original de x seja alterado

//13 - Qual a diferença entre os parâmetros out e o parâmetro ref ?
//ref significa que o método pode ler ou gravar o valor do argumento. out significa que o método define o valor do argumento

//14- O que são argumentos nomeados ?
//é quando passamos o nome dos parâmetros, seguidos de seus valores, podendo utilizar um método, passando suas propriedades em qualuqer ordem, desde que elas estejam nomeadas.

//15- O que são parâmetros opcionais ?
//é quando atribuimos um valor padrão a um parâmetro, fazendo com que não seja necessário atribuir um valor a ele ao chamar um método.

//16- Qual o efeito da palavra-chave static ?
//faz com que os métodos da classe estejam associados a classe e não com uma instância particular da classe

//17 - O que é método estático e qual o seu comportamento ?
//os métodos estáticos pertencem a classe, ou seja não precisam da instanciação de um objeto para serem chamados, tem a seguinte sintaxe: Classe.Metodo();

//18- O que é um campo estático e qual o seu comportamento ?
//é um campo usado para ser inicializado antes de qualquer dado estático, e que será somente executado uma vez na execução do programa.

//19 - O que são propriedades ?
//combinação de um campo privado e dois acessadores, o get (como o dado vai ser recebido) e o set(como o dado vai ser colocado no sistema), 
//suas vantagens são: -permitem um controle maior de como os dados se comportam no sistema; -deixam o código mais flexível;

//20- Qual a diferença entre campos e propriedades ?
//as propriedades permitem um controle maior dos dados, enquanto nas classes, podemos ler e escrever (get e set) qualquer atributo, com as propriedades
//podemos definir melhor os parâmetros que podem ou não entrar.

//21- O que é uma struct ?
//struct possui as mesmas funcionalidades que uma classe, porém, enquanto a classe guarda seus dados na memória HEAP, uma struct guarda seus dados na memória stack,
//sendo uma alternativa mais leve que a classe, porém, não podemos guardar muitos dados, por conta da STACK possuir menos espaço, correndo o risco de um stack overflow.

//22- Qual a diferença entre uma struct e uma classe ?
//a struct guarda seus dados na memória STACK e a classe na memória HEAP, classe é mais recomendada para grande quantidade de dados.

//23- O que é uma Enum ?
//é um tipo de classe que se comporta como um array, podendo guardar objetos e ser acessado a partir de seu índice, podemos definir seu índice no enum.

//24- Quais são e qual o escopo dos modificadores de acesso ?
//public: acesso geral a todos os assemblys, private: acesso apenas a classe em que foi criado, protected: o assmebly pode ser acessado na própria classe 
//e também nas classes filhas.

//25- Qual a regra geral para usar os modificadores de acesso ?
//são palavras que definem o acesso de um campo, método e classe, um exemplo de um método com modificador público: public void MeuMetodoPublico(){  }.

