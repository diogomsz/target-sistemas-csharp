using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace target_sistemas.questao2;

public class Fibonacci
{
    public static bool Fibo(int n)
    {
        int x = 1, y = 0, z = 0;

        while(n >= z)
        {
            z = x + y;
            Console.WriteLine(z);
            if (z == n)
            {
                return true;
            }
            y = x;
            x = z;
        }

        return false;
    }
}
