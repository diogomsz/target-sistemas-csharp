using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_sistemas.questao4;

public class FaturamentoMensal
{
    public static List<FaturamentoPorcentagem> CalculaPorcentagem()
    {
        List<FaturamentoPorcentagem> porcentagem = new();
        List<FaturamentoPorEstado> f = RetornaValorFaturamento();

        double somaTotal = f.Sum(x => x.valor);
        double porcentagemAux;

        f.ForEach(p =>
        {
            porcentagemAux = p.valor / somaTotal;
            porcentagem.Add(new FaturamentoPorcentagem(p.estado, porcentagemAux));
        });

        return porcentagem;
    }

    private static List<FaturamentoPorEstado> RetornaValorFaturamento()
    {
        List<FaturamentoPorEstado> faturamentoEstadual = new()
    {
        new FaturamentoPorEstado("SP", 67836.43),
        new FaturamentoPorEstado("RJ", 36678.66),
        new FaturamentoPorEstado("MG", 29229.88),
        new FaturamentoPorEstado("ES", 27165.48),
        new FaturamentoPorEstado("Outros", 19849.53),
    };

        return faturamentoEstadual;
    }
}
