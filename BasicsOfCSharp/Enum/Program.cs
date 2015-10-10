using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Colors b = Colors.Black;
            Colors r = Colors.Red;
            Colors count = Colors.Number;
            Console.WriteLine(b);//Black
            Console.WriteLine(r);//Red
            Console.WriteLine(count);//Number
            Console.WriteLine();
            Console.WriteLine("{0} color = {1}", count, (int)count);//Count color = 9

            Console.ReadKey();
        }
    }
    enum Colors
    {
        Red,
        Blue,
        Yellow,
        Green,
        Ornage,
        Violet,
        Indigo,
        Black,
        White,
        Number = 9
    }
}
