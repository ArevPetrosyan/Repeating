using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A a = new B();");
            Console.WriteLine("a.F()");
            Console.WriteLine("a.E()");
            Console.WriteLine();
            A a = new B();
            a.F();
            a.E();
            Console.WriteLine();
            Console.WriteLine("A c = new A();");
            Console.WriteLine("c.F()");
            Console.WriteLine("c.E()");
            Console.WriteLine();
            A c = new A();
            c.F();
            c.E();
            Console.WriteLine();
            Console.WriteLine("B d = new B();");
            Console.WriteLine("d.F()");
            Console.WriteLine("d.E()");
            Console.WriteLine();
            B d = new B();
            d.F();
            d.E();
            Console.WriteLine();
            
            Console.Read();
        }
    }

    class A
    {
        virtual public void F()
        {
            Console.WriteLine("Method F: Class A: Virtual");
        }
        public void E()
        {
            Console.WriteLine("Method E: Class A");
        }
    }
    class B : A
    {
        override public void F()
        {
            Console.WriteLine("Method F: Class B: Override");
        }
        public void E()
        {
            Console.WriteLine("Method E: Class B");
        }
    }
}