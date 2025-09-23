namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Human h1 = new Human(); // Base constructor
            // h1.id = "AAAAA"; id is a private attribute Can not change

            //Human h2 = new Human("Lars", 29); // Constructor hvor du sender verdier til attributter

            //Console.WriteLine(h2.name);

            //Human h3 = new Human("Lars", 99, "BBBBB");

            //Console.WriteLine(h3.id);


            //PlayingCard c1 = new PlayingCard(10, "Clubs");

            //Console.WriteLine(c1.suit);

            //Human h4 = new Human("Robert", "BBB");

            List <Human> humans = new List<Human>();
            string choise;
            bool running = true;

            while (running == true)
            {
                Console.WriteLine("Press 1 for adding Customers to the database or 2 for printing or 3 for exit");

                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":

                        Human human = new Human();
                        Console.WriteLine("Give me the name of the costomer: ");
                        human.name = Console.ReadLine();

                        Console.WriteLine("Give me the age of the costomer: ");
                        human.age = Convert.ToInt32(Console.ReadLine());

                        humans.Add(human);

                        break;



                    case "2":

                        if (humans.Count == 0)

                        {
                            Console.WriteLine("No Customers in database");
                        }

                        else
                        { 
                            Console.WriteLine("\n-----Costomer List");

                            foreach (var h in humans)
                            {
                                Console.WriteLine("Name: " + h.name + ", Age: " + h.age);
                            }
                        }                        
                        break;




                    case "3":

                    running = false;
                        Console.WriteLine("Goodbye!");
                    break;



                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;


                    case "4":

                }

            }

          
        }
    }
}
