using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            //one-dimensional array
            int[] array1 = new int[] {1, 2, 3, 4, 5};
            int[] array2 = new int[4];
            array2[0] = 4;
            array2[1] = 4;
            array2[2] = 4;
            array2[3] = 4;
            Console.WriteLine("one-dimensional array");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Object array");
            object[] obj = new object[] {"string object", 123, false, new DateTime(2015, 10, 10)};
            foreach (object item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //two-dimensional array
            int[,] ar1 = new int[,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            Console.WriteLine("two-dimensional array");
            for (int i = 0; i  < 3; i ++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ar1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //jagged Array
            Console.WriteLine("jagged Array");
            int[][] jagArray = new int[5][];
            for (int i = 0; i < jagArray.Length; i++)
            {
                jagArray[i]=new int[i+1];
            }

            for (int i = 0; i < jagArray.Length; i++)
            {
                for (int j = 0; j < jagArray[i].Length; j++)
                {
                    Console.Write(jagArray[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //work on arrays

            Console.WriteLine("work on arrays");
            Console.WriteLine("Revers(), Rank, Clear(), CopyTo(), Lenght, Sort()");
            Console.WriteLine();

            

            Console.WriteLine("Revers() array");
            foreach (int item in array1)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Reverse Array");
            Array.Reverse(array1);
            

            for (int i = 0; i < array1.Length; i++ )
            {
                Console.Write(array1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sort Array");
            Array.Sort(array1);
            foreach (int item in array1)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("Rank Array []");
            Console.WriteLine(array1.Rank);
            Console.WriteLine();
            Console.WriteLine("Rank Array [,]");
            Console.WriteLine(ar1.Rank);
            
            Console.WriteLine("Rank Array [][]");
            Console.WriteLine(jagArray.Rank);
            
            Console.ReadKey();
        }
    }
