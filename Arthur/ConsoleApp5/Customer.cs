using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Customer
    {
        public string name;
        public string address;
        public string city;
        public double balance;

        public Customer()
        {
            name = "   ";
            address = "unknown";
            balance = 0;
            city = "unknown";
        }

        /*
        public Customer(string _name, string _address, string _city, double _balance) // Old school
        {
            name = _name;
            address = _address;
            city = _city;
            balance = _balance;

        }
        */

        public Customer(string name, string address, string city, double balance) // new way to do the same
        {

            this.name = name;
            this.address = address;
            this.city = city;
            this.balance = balance;

        }

        // methods
        public void printData()
        {
            Console.WriteLine(name+"\n"+address+"\n"+city);
        }


    }
}
