


using System;

class GuessingGame
{
    static void Main()
    {
        Console.WriteLine("=== Number Guessing Game ===");
        Console.WriteLine("I'm thinking of a number between 1 and 100!");

        Random random = new Random();
        int secretNumber = random.Next();
        int attemts = 0;
        int Max attemts = 7;
        bool hasWon = false;


    }
}