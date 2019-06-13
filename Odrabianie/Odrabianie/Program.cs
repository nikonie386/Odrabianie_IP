using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odrabianie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            int d = a * b;
            int f = a * c;

            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            Console.WriteLine("{0} * {1} = {2}", a, b, d);
            Console.WriteLine("{0} * {1} = {2}", a, c, f);
            Console.WriteLine("Próba na gałąź rozwojową");
            Console.ReadKey();
        }
    }
}
