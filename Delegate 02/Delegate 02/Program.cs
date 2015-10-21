using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_02
{
    delegate void myDell(int x);
    class Program
    {
        static void Main(string[] args)
        {
            myDell mdell = new myDell(Start);
            mdell += Stop;
            mdell(100);

            Console.WriteLine();
            Console.Read();
        }

        static void Start(int x)
        {
            Console.WriteLine("go is: {0}", x);
        }

        static void Stop(int y)
        {
            y = 0;
            Console.WriteLine("Stop: {0}", y);
        }
    }

}
