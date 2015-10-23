using System;
using System.Threading;
namespace Event02
{
    delegate void DelegatePrinter();
    delegate void DelegatePrintPage(int x);

    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            DelegatePrinter dS = new DelegatePrinter(StartPrinter);
            DelegatePrintPage dPages = new DelegatePrintPage(PrintPage);
            DelegatePrinter dE = new DelegatePrinter(PrintExit);

            Console.Write("Number of pages: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            p.Click += dS;
            p.OnStart();
            p.PrPage += dPages;
            p.PrintYourPage(c);
            p.ExPrint += dE;
            p.ExitPrint();
            Console.Read();
        }

        static void StartPrinter()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Printer Starting...");
            Console.WriteLine();
        }
        static void PrintPage(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Printed paje: {0}", i);
                Console.WriteLine("Remaining: {0}", x - i);
                Console.WriteLine();
            }
        }
        static void PrintExit()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Printing finished.");
        }

    }
    class Printer
    {
        public event DelegatePrinter Click;
        public event DelegatePrintPage PrPage;
        public event DelegatePrinter ExPrint;
        public void OnStart()
        {
            if (Click != null)
                Click();
        }
        public void PrintYourPage(int x)
        {
            if (PrPage != null)
                PrPage(x);
        }
        public void ExitPrint()
        {
            if (ExPrint != null)
                ExPrint();
        }
    }
}

