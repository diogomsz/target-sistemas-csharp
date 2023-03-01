using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_sistemas.questao2
{
    public class Fibonacci
    {
        public int Fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }

        public void FindValueFibo(int value)
        {
            for(int i = 0; i < value; value--)
            {
                if(value == Fibo(value))
                {
                    Console.WriteLine($"O valor {value} pertence à sequência");
                } else
                {
                    Console.WriteLine($"O valor {value} não pertence à sequência");
                }
            }
        }
    }


}
