﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 150;
            for (int i = 0; i < 5; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
}
