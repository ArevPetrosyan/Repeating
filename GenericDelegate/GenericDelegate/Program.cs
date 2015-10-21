using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegate<string> stDel = new MyGenericDelegate<string>(StringTarget);
            MyGenericDelegate<int> intDel = new MyGenericDelegate<int>(IntTarget);
            stDel("type string");
            intDel(15);

            Console.Read();

        }
        static void StringTarget(string arg)
        {
            Console.WriteLine(arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine(++arg);
        }
    }
}
