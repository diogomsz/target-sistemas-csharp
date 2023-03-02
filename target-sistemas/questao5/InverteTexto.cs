using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_sistemas.questao5;

public class InverteTexto
{
    public static string RetornaTextoInvertido(string texto)
    {
        string[] vetorTextoInvertido = InvertendoTexto(texto);
        string textoInvertido = String.Join("", vetorTextoInvertido);

        return textoInvertido;
    }

    private static string[] InvertendoTexto(string texto)
    {
        string aux;
        string[] vetorTexto = texto.ToCharArray().Select(c => c.ToString()).ToArray();
        int i = 0;
        int j = texto.Length - 1;

        while(i < j)
        {
            aux = vetorTexto[i];
            vetorTexto[i] = vetorTexto[j];
            vetorTexto[j] = aux;
            i++;
            j--;
        }

        return vetorTexto;
    }
}
