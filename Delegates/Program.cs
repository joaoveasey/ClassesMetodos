// DELEGATE PREDICATE: método que recebe um argumento de tipo T e retorna um bool.

// DELEGATE ACTION: método que não retorna um valor, as pode receber até 16 args de entrada, útil para representar um método que executa uma ação e não retorna nada

// DELEGATE FUNC: recebe de 1 a 16 args do tipo T de entrada e retorna um valor do tipo TResult, útil para representar um método que executa uma operação e retorna um resultado.


//---------- usando um deleagte PREDICATE -----------
//Console.WriteLine("Informe um número inteiro");
//int numero = Convert.ToInt32(Console.ReadLine());

//Predicate<int> delegatePar = x => x % 2 == 0; 

//if (delegatePar(numero))
//{
//    Console.WriteLine("PAR");
//}
//else
//{
//    Console.WriteLine("IMPAR");
//}

//Console.ReadKey ();

//---------- usando um delegate ACTION -----------

//Console.WriteLine("Informe um numero inteiro: ");
//int numero = Convert.ToInt16(Console.ReadLine());

//Action<int> dobra = x => Console.WriteLine(x * 2);
//dobra(numero);

//Console.ReadKey();

//---------- usando um delegate FUNCTION -----------

double numero = Convert.ToDouble(Console.ReadLine());

Func<double,double> raizQuadrada = x => Math.Sqrt(x);

double resultado = raizQuadrada(numero);

Console.WriteLine(resultado);

Console.ReadKey();