using System;

class Program
{
    static void Main(string[] args)
    {
        // Set playAgain to true to start the game and keep it true until player says no
        bool playAgain = true;

        // Game loop
        while (playAgain)
        {
            bool num_guessed = false;
            Random rand = new Random();
            int magic_num = rand.Next(1,101);

            int num_of_guesses = 0;

            // Loop to have user enter guesses
            while (num_guessed is false)
            {
                Console.Write("Enter your guess: ");
                int magic_num_guess = int.Parse(Console.ReadLine());
                num_of_guesses += 1;

                // Game logic: if the user number is lower the program says that the user needs to enter a higher number and vice versa
                if (magic_num_guess < magic_num)
                {
                    Console.WriteLine("Higher");
                }
                else if (magic_num_guess > magic_num)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You got it! It only took you {num_of_guesses} tries.");
                    num_guessed = true;
                }
            }
            Console.Write("Would you like to play again (y or n)? ");
            // Reads what the user entered, converts it to lowercase and if it is y playAgain == true and if not it is equal to false and the game ends.
            playAgain = Console.ReadLine().ToLower() == "y" ? true : false;
        }
    }
}