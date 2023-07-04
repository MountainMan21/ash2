using System;

class Program
{
    static void Main()
    {
        // Generate a random number between 1 and 100
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        bool guessedCorrectly = false;
        int attempts = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");

        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess (1-100): ");
            string input = Console.ReadLine();

            // Validate the user's input
            int guess;
            if (!int.TryParse(input, out guess) || guess < 1 || guess > 100)
            {
                Console.WriteLine("Invalid guess. Please enter a number between 1 and 100.");
                continue;
            }

            attempts++;

            if (guess == randomNumber)
            {
                guessedCorrectly = true;
                Console.WriteLine("Congratulations! You guessed the correct number in " + attempts + " attempts.");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}