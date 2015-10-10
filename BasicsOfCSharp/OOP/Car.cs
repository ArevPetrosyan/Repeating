using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        public string petName;
        public int currSpeed;
        public Car()
        {
            petName = "NameCar";
            currSpeed = 0;
        }
        public Car(string name):this(name, 0){}
        public Car(string name, int currSpeed)
         {
            petName = name;
            this.currSpeed = currSpeed;
        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }
    }
}
