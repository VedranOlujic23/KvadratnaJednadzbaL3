using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.KvadratnaJednadzba
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);

            var roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);

            qe = new QuadraticEquation(-1, 2, -1);

            roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);

            Console.ReadKey(false);
            //DZ: ZADATAK 3 
        }
    }
}
