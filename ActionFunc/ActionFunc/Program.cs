using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Action<int, int, string> MetA = new Action<int, int, string>(MethodAc);
            Func<int, int, int, int> MetF = new Func<int, int, int, int>(MethodFunc);
            //arajin int@ veradarcvox arjeqn e, mnacac 3-@ stacox parametreri tiper@
            int F = MetF(12, 3, 5);
            MetA(5, 6, "my name");

            Console.WriteLine("Method Func");
            Console.WriteLine(F);

            Console.WriteLine();
            Console.Read();
        }
        static void MethodAc(int x, int y, string name)
        {
            Console.WriteLine("Method Action"+Environment.NewLine+"x = {0}, y = {1}, name = {2}", x, y, name);
        }
        static int MethodFunc(int x, int y, int z)
        {
            return x * y * z;
        }
    }
}
