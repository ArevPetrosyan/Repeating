using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 15;
            p.Y = 45;
            p.Display();
            p.Increment();
            p.Display();
            p.Decrement(10);
            p.Display();
            p.Increment(10);
            p.Display();

            Point pp = new Point(50, 60);

            Console.ReadKey();
        }
    }
    struct Point
    {
        public int X;
        public int Y;
        //public int Z = 10; can not be initialized fields
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Increment()
        {
            X++;
            Y++;
        }
        public void Increment(int a)
        {
            X += a;
            Y += a;
        }
        public void Decrement()
        {
            X--;
            Y--;

        }
        public void Decrement(int a)
        {
            X -= a;
            Y -= a;
        }
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
