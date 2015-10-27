using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            new Child();
            Console.Read();
        }
    }

    class Parent
    {
        static Parent()
        {
            Console.WriteLine("static Parent");
        }
        public Parent()
        {
            Console.WriteLine("Pablic Parent");
        }
    }
    class Child : Parent
    {
        static Child()
        {
            Console.WriteLine("static Child");
        }
        public Child()
        {
            Console.WriteLine("Pablic Child");
        }
    }
}
