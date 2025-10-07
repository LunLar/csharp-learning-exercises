using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class PremiumCustomer:Customer
    {

        public string status;
        public string airline;
        public int flights;



        // Basis Constructor
        public PremiumCustomer()
        {
            status = "  ";
            airline = "  ";
            flights = 0;

        }




        public PremiumCustomer(string status, string airline, int flights)
        {
            this.status = status;
            this.airline = airline;
            this.flights = flights;

        }

        public void printData()
        {
            Console.WriteLine(status + "\n" + airline + "\n" + flights);
        }








    }
}
