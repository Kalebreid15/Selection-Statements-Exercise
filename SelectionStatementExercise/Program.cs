using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favnumber = r.Next(1, 1000); // Generates a random number between 1 and 1000

            Console.WriteLine("Welcome to the Number Guessing Game!");

            Console.WriteLine("Guess a number between 1 and 1000:");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int response))
            {
                if (response < favnumber)
                {
                    Console.WriteLine($"Your guess of {response} is too low. Try again!");
                }
                else if (response > favnumber)
                {
                    Console.WriteLine($"Your guess of {response} is too high. Try again!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number: {favnumber}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}


