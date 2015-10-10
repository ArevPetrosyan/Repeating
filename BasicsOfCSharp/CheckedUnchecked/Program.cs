using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 200;
            byte b = 150;
            byte c=(byte)Add(a,b);
            Console.WriteLine(c);//return c=94--->350-256=94
            Console.WriteLine();
            try
            {
                checked
                {
                    c = (byte)Add(a,b);
                    Console.WriteLine(c);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static int Add(int a, int b)
        {
            return a+b;
        }
    }
}
