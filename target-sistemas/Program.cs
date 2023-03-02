using target_sistemas.questao2;
using target_sistemas.questao3;

internal class Program
{
    private static void Main(string[] args)
    {
        FaturamentoDiario.Ler();
    }

    public static void Q1()
    {
        Console.Write("Digite um termo para sequência: ");
        int n = int.Parse(Console.ReadLine());

        if (Fibonacci.Fibo(n))
        {
            Console.WriteLine("Pertence à sequência");
        }
        else
        {
            Console.WriteLine("Não pertence à sequência");
        }
    }
}