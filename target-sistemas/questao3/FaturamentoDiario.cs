using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace target_sistemas.questao3;

public class FaturamentoDiario
{
    public static void Ler()
    {
        string fileName = "C:\\Users\\diogo\\OneDrive\\Ambiente de Trabalho\\project_dev\\dotnet_project\\target-sistemas\\target-sistemas\\dados.json";
        using StreamReader stream = new(fileName);
        string json = stream.ReadToEnd();
        List<Faturamento>? faturamento = JsonSerializer.Deserialize<List<Faturamento>>(json);

        double fMenor = faturamento.MinBy(x => x.valor).valor;
        Console.WriteLine($"Menor valor de faturamento: {fMenor:c}");

        double fMaior = faturamento.MaxBy(x => x.valor).valor;
        Console.WriteLine($"Maior valor de faturamento: {fMaior:c}");

        int dia = 0;
        double fMedia = faturamento.Sum(x => x.valor) / faturamento.Count;

        faturamento.ForEach(x =>
        {
            if(x.valor > fMedia)
            {
                dia++;
            }
        });

        Console.WriteLine($"Quantidade de dias onde o valor é superior a média mensal: {dia}");
    }
}
