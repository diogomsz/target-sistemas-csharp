using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_sistemas.questao4
{
    public class FaturamentoPorEstado
    {
        public string estado { get; set; }
        public double valor { get; set; }

        public FaturamentoPorEstado(string estado, double valor)
        {
            this.estado = estado;
            this.valor = valor;
        }
    }
}   
