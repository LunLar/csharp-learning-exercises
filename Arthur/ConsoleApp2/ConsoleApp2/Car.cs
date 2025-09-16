using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Car
    {
        public string brand;
        public int year;
        public string color;
        public string regNR;
        public int size;
        public int number_of_wheels;


        public Car()
        {
            size = 50;
            number_of_wheels = 4;

        }


        public void drive()
        {
            Console.WriteLine("I am driving");
        }

    }
}
