using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcular o fatorial de qual número? ");
            int resultado = int.Parse(Console.ReadLine());            
            Console.WriteLine(Fatorial(resultado));
            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);

        }
    }
}
