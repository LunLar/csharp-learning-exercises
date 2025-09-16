using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Human
    {
        public string name; //this is how we create attributes   Python-> __intit__ (self, name, age)
        public int age;
        private string id;
        public int healthpoints;
        
        //Constructor 

        // Basis Constructor
        public Human()
        {
            // When i create a new object ... the following initial values are set
            healthpoints = 100;
            name = "Ola Nordman";
        }


        // methods how to create

        public void walk()
        {
            Console.WriteLine("I am walking");

        }

        public void fight()
        {
            Console.WriteLine("I am fighting");

        }

        public void jumping()
        {
            Console.WriteLine("I am Jumping");
        }



    }
}
