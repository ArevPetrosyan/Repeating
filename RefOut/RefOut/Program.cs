using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Jon";
            Console.WriteLine("minchev poxel@");
            Console.WriteLine(p.name);
            Console.WriteLine("kancheci F functian");
            F(ref p);
            Console.WriteLine("noric mer p person@");
            Console.WriteLine(p.name);
            Console.WriteLine();
            Console.WriteLine("///////////////////");
            int X = 100;
            Console.WriteLine("skzbum X= {0}", X);
            Console.Write("heto kancheci D-n: ");
            D(out X);
            Console.WriteLine("hima eli mer X-@: {0}", X);
            Console.WriteLine("///////////////////");
            string s1 = "my string";
            Console.WriteLine("skzbum s1: {0}", s1);
            Console.Write("heto kanchecinq E: ");
            E(ref s1);
            Console.WriteLine("hima noric mer s1= {0}", s1);
            Console.Read();

        }
        static void F(ref Person p1)
        {
            p1.name = "Bob";
            Console.WriteLine(p1.name);
        }
        static void D(out int x)
        {
            x = 50;
            Console.WriteLine(x);
        }
        static void E(ref string s)
        {
            s = "new string";
            Console.WriteLine(s);
        }
    }

    class Person
    {
        public string name;
    }
}


