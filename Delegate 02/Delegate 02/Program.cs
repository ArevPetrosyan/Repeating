using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegate_02
{
    public delegate void Dell1(int x, Dell2 d);
    public delegate void Dell2();

    class Program
    {
        static void Main(string[] args)
        {
            Dell2 del2 = new Dell2(Go);
            Dell1 del1 = new Dell1(Start);
           
            del1(10, del2);

            
       
            Console.WriteLine();
            Console.Read();
        }

        public static void Start(int x, Dell2 d)
        {
            for (int i = 0; i < x; i++)
            {
                d();
                Thread.Sleep(1000);
                Console.Write(i);
                Console.WriteLine();
            }
        }

        public static void Go()
        {
            Console.Write("go to: ");
        }
        
    }

}
