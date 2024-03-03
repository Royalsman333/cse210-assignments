using System;

class Program
{
    static void Main(string[] args)
    {
        int playAgain = 1;

        while (playAgain == 1)
        {
            
            //For the user to input their "Magic Number" instead of it randomly being chosen
            //Console.Write("What is the magic number? ");
            //int magicNumber = int.Parse(console.ReadLine());

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int count = 0;

            while (guess != magicNumber)
            {
                Console.Write("Guess the Magic Number: ");
                guess = int.Parse(Console.ReadLine());
                count++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Your guess was too low, try again!");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Your guess was too high, try again!");
                }
                else
                {
                    Console.WriteLine("You guessed the Magic Number!");
                    Console.WriteLine($"You guessed the Magic Number in {count} guesses!");
                }
            }

            Console.Write("Would you like to play again? '1' = Yes, '2' = No ");
            playAgain = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Thank you for playing! Have a great day!");
    }
}