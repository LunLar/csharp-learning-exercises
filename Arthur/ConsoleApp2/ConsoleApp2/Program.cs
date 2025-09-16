using System.Security.Cryptography;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[3]; // this is an array of strings with a fixed size of 3
            int[] numbers = new int[4];
            double[] prizes = new double[3];
            int i;
            string temp;
            double sum, averege;
            sum = 0;
            string[] activeties = new string[10];



            // how to read an array

            for (i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("give me the name of a city");
                temp = Console.ReadLine();
                cities[i] = temp; // cities at pos. 0 is the first element

            }

            // how to print an array

            for (i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("the name of the city was: " + cities[i]);
            }

            //how to print an arry Version 2

            foreach(string c in cities)
            {
                Console.WriteLine("the name of the city was: " + c);
            }



            for (i = 0; i < prizes.Length; i++)
            {
                Console.WriteLine("give me the prize");
                prizes[i] = Convert.ToDouble(Console.ReadLine());


                sum += prizes[i];



            }
            averege = sum / prizes.Length;
            Console.WriteLine("The average is " + averege);


            for (i = 0; i < activeties.Length; i++)
            {
                Console.WriteLine("give me an activety");
                temp = Console.ReadLine();
                activeties[i] = temp; // cities at pos. 0 is the first element

            }

            for (i = 0; i < activeties.Length; i++)
            {
                Console.WriteLine("the name of the activety was: " + activeties[i]);
            }


            // i want to create an object of my class Human!
            // Python -> H = Human()

            Human h1 = new Human(); // new object of class human

            Console.WriteLine("Give me the name of a human: ");
            h1.name = Console.ReadLine();

            Console.WriteLine("Give me the age of the human: ");
            h1.age = Convert.ToInt32(Console.ReadLine());
            
            //h1.id //Cannot reach the position of he.id becaouse it is private


            Car car_1 = new Car();

            Console.WriteLine("Give me the brand of a car: ");
            car_1.brand = Console.ReadLine();
           
            Console.WriteLine("The brand is: "+ car_1.brand);

            Console.WriteLine("The cars has" + car_1.number_of_wheels + "wheels");

            car_1.drive();


            Human h2 = new Human();

            Console.WriteLine(h2.healthpoints);

            h2.walk();
            h2.fight();

            


        }
    }
}
