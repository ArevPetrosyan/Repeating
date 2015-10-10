using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int c, d, e;
            Add(a, b, out c, out d, out e);
            Console.WriteLine("OUT");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("a+b={0}", c);
            Console.WriteLine("a-b={0}", d);
            Console.WriteLine("a*b={0}", e);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("REF");
            string s = "Flip";
            string ch = "Flop";
            Console.WriteLine("{0}, {1}", s, ch);
            SwapStr(ref s, ref ch);
            Console.WriteLine("{0}, {1}", s, ch);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Add(int a, int b, out int c, out int d, out int e)
        {
            c = a + b;
            d = a - b;
            e = a * b;

        }
        static void SwapStr(ref string s, ref string ch)
        {
            string sw = s;
            s = ch;
            ch = sw;
        }
    }
}
