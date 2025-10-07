namespace ConsoleApp5
{
    internal class Program
    {
        static List<Customer> customers = new List<Customer>();
        static void addCustomers()
        {

            string name, address;

            Console.WriteLine("What is the name of the customer?");
            name = Console.ReadLine();

            Console.WriteLine("What is the address of the customer?");
            address = Console.ReadLine();

            customers.Add(new Customer(name, address, "unknown", 0.0));


            

        }


        static void Main(string[] args)
        {


            /*
            Customer c1 = new Customer();
            Console.WriteLine("What is the name of the customer?");
            c1.name = Console.ReadLine();

            Console.WriteLine("What is the address of the customer?");
            c1.address = Console.ReadLine();

            // Console.WriteLine("your values given were " +c1.name+ " " +c1.address);

            c1.printData();


            PremiumCustomer p1 = new PremiumCustomer();
            p1.printData();
            */

            int choise;

            do
            {
               
                Console.WriteLine("Welcome - press 1 for adding customer - 9 for exit");

                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:

                        addCustomers();
                        break;

                    // to be continued

                    case 9:

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choise < 9);


        }

    }
}
