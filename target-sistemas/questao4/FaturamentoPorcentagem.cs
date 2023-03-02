using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_sistemas.questao4;

public class FaturamentoPorcentagem
{
    public string estado { get; set; }
    public double porcentagem { get; set; }

    public FaturamentoPorcentagem(string estado, double porcentagem)
    {
        this.estado = estado;
        this.porcentagem = porcentagem;
    }
}
