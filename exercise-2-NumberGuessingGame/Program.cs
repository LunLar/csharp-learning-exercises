

using System;

class GuessingGame
{
    static void Main()
    {
        Console.WriteLine("=== Number Guessing Game ===");
        Console.WriteLine("I'm thinking of a number between 1 and 100!");

        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int attempts = 0;
        int maxAttempts = 7;
        bool hasWon = false;

        while (attempts < maxAttempts && !hasWon)
        {
            Console.Write($"Attempt {attempts + 1}/{maxAttempts} - Enter your guess: ");

            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                attempts++;

                if (guess == secretNumber)
                {
                    Console.WriteLine($"🎉 Congratulations! You guessed it in {attempts} attempts!");
                    hasWon = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Too high! Try a lower number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }

        if (!hasWon)
        {
            Console.WriteLine($"😔 Game over! The number was {secretNumber}");
        }

        Console.WriteLine("Thanks for playing!");
    }
}