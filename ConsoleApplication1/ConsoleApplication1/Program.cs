using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = new int[5] { 1, 2, 3, 4, 5 };
            int resultado = Somar(val);
            Console.WriteLine(resultado);
            Console.WriteLine(fatorial(32));
            Console.ReadKey();
        }

        static int Somar(int[] valores)
        {
            int resultado = 0;

            for (int i = 0; i < valores.Length; i++) 
            {
                resultado += valores[i];
            }
            return resultado;
            }
        
        
        static long fatorial(long n)
        {
            if (n == 0) 
            {
                return 1;
            }
            else
            {
                return n* fatorial(n - 1);
            }
                
        }

    }
}
