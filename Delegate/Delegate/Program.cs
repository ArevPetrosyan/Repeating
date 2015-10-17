using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    delegate void Del();
    delegate int DelInt(int x);

    class Program
    {
        static void Main(string[] args)
        {

            Del del = new Del(M1);
            del += MM;

            // del += M2;


            DelInt delint = new DelInt(M2);
            Console.WriteLine(delint(40));
            del();
            Console.WriteLine("del-M1");
            del -= M1;
            del();

            Console.Read();
        }
        static void M1()
        {
            Console.WriteLine("M1 method");
            Console.Read();
        }
        static void MM()
        {
            Console.WriteLine("Method MM");
            Console.Read();
        }
        static int M2(int x)
        {
            return x * x;
        }
    }


}
