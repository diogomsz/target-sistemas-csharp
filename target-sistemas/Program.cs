using target_sistemas.questao2;

Console.Write("Digite um termo para sequência: ");
int n = int.Parse(Console.ReadLine());

Fibonacci f = new();

f.FindValueFibo(n);
