


using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("===== Simple Calculator =====");



        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());


        double result = 0;
        bool validOperation = true;


        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                result = num1 / num2;
                break;
                
        }













    }
}