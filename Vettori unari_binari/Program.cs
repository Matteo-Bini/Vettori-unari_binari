using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori_unari_binari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vec Vettore1 = new Vec(2, 7);
            Vec Vettore2 = new Vec(1, 9);
            Console.WriteLine(Vettore1 + Vettore2);
            Console.WriteLine(Vettore1 - Vettore2);
            Console.WriteLine(+Vettore1);
            Console.WriteLine(-Vettore1);
            Console.ReadLine();
        }
    }
}
