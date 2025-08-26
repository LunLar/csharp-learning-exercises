using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void addition() // if we have a function which does not return a value we use void......
        {
            double nr1;
            double nr2;
            double result;


            Console.WriteLine("Give me your first number");
            nr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give me your second number");
            nr2 = Convert.ToDouble(Console.ReadLine());

            result = nr1 + nr2;

            Console.WriteLine("The result is " + result);
        }  // This is a function body also called function deffinition
        

        static double substraction() // må definere hvilkne type data du returnerer
        {
            double nr1;
            double nr2;
            double result;


            Console.WriteLine("Give me your first number");
            nr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give me your second number");
            nr2 = Convert.ToDouble(Console.ReadLine());

            result = nr1 - nr2;

            return result;


        }


        static double multiply(double number1, double number2) // må definere hvilkne type data du henter double nr1
        {
            double r;
            r = number1 * number2;

            return r;


        }

        static void division(double number1, double number2) // må definere hvilkne type data du henter double nr1
        {
            double r;
            r = number1 / number2;

            Console.WriteLine("The result is " + r);

        }




        static void Main(string[] args)
        {
            string choice; // declare my variable in  the beginning. char choise;
            double result; // declare result
            double nr1;
            double nr2;




            do
            {

                Console.WriteLine("Welcome to my Calculator");
                Console.WriteLine("Press a for additiion, b for substraction, c for multiply or d for divide and e for exit");



                choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":

                        // Addition of 2 numbers
                        addition(); // this is a function call
                        break;



                    case "b":

                        // Substraction of 2 numbers
                        result = substraction();
                        Console.WriteLine("The result is " + result);
                        break;



                    case "c":

              
                        Console.WriteLine("Give me your first number");
                        nr1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Give me your second number");
                        nr2 = Convert.ToDouble(Console.ReadLine());

                        result = multiply(nr1, nr2); // functioncall does not need datatypes. Double.....
                        Console.WriteLine("The result is " + result);


                        break;



                    case "d":


                        Console.WriteLine("Give me your first number");
                        nr1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Give me your second number");
                        nr2 = Convert.ToDouble(Console.ReadLine());

                        division(nr1, nr2);

                        break;




                }
            } while (choice != "e");

            
        }
    }
}
