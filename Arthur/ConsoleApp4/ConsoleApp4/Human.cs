using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Human // Stor bokstav på Classes
    {
        // Attributes
        public string name; // Variabler med små bokstaver
        public int age;
        private string id;



        // Constructor
        // we have to have a base constructor
        // base constructor as initialization
        public Human()
        {
            name = "Unknown";
            age = 0;
            id = "unknown";

        }

        public Human(string _name, int _age, string _id)
        {
            name = _name;
            age = _age;
            id = _id;
        }

        public Human(string _name, string _id)
        {
            name = _name;
            id = _id;
        }

        public Human(string _name, int _age)
        {
            name = _name;
            age = _age;
        }



    }
}
