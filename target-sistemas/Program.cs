using target_sistemas.questao2;
using target_sistemas.questao3;
using target_sistemas.questao4;
using target_sistemas.questao5;

internal class Program
{
    private static void Main(string[] args)
    {

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

    public static void Q2()
    {
        FaturamentoDiario.Ler();
    }

    public static void Q3()
    {
        List<FaturamentoPorcentagem> fp = FaturamentoMensal.CalculaPorcentagem();
        fp.ForEach(x =>
        {
            Console.WriteLine($"Estado: {x.estado} - Porcentagem de representação: {x.porcentagem:P}");
        });
    }

    public static void Q4()
    {
        Console.Write("Digite uma frase ou palavra: ");
        string texto = Console.ReadLine();

        string textoInvertido = InverteTexto.RetornaTextoInvertido(texto);
        Console.WriteLine($"Texto invertido: {textoInvertido}");
    }
}