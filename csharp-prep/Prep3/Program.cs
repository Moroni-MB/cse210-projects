using System;

class Program
{
    static void Main(string[] args)
    {
        bool game_start = true;

        while (game_start is true)
        {
            // Console.Write("Enter the magic number: ");
            // int magic_num = int.Parse(Console.ReadLine());
            bool num_guessed = false;
            Random rand = new Random();
            int magic_num = rand.Next(1,101);

            int num_of_guesses = 0;

            // Console.WriteLine("Enter your guess: ");
            // int magic_num_guess = int.Parse(Console.ReadLine());

            // if (magic_num_guess < magic_num)
            // {
            //     Console.WriteLine("Higher");
            // }
            // else if (magic_num_guess > magic_num)
            // {
            //     Console.WriteLine("Lower");
            // }
            // else
            // {
            //     Console.WriteLine("You got it!");
            // }

            while (num_guessed is false)
            {
                Console.Write("Enter your guess: ");
                int magic_num_guess = int.Parse(Console.ReadLine());
                num_of_guesses += 1;

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
            string play = Console.ReadLine().ToUpper();
            if (play == "Y")
            {
                game_start = true;
            } else
            {
                game_start = false;
            }
        }
    }
}