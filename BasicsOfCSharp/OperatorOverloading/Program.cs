using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(5, 15);
            Point p12 = p1 + p2;
            p1 = p2 + 5;
            p1 +=p2;
           
            int a = 1;
            Console.WriteLine(a.IsOdd());
            Console.WriteLine((++a).IsOdd());
            Console.Read();
            

        }
    }
    public static class IntEx
    {
       public static bool IsOdd(this int a)
        {
            return a % 2 == 1;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = x;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X+p2.X, p1.Y+p2.Y);
        }
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator +(Point p1, int a)
        {
            return new Point(p1.X + a, p1.Y + a);
        }
        public static Point operator +(int a, Point p1)
        {
            return new Point(p1.X + a, p1.Y + a);
        } 
    }
}

