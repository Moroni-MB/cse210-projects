using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        
        // string firstName = "Bob";

        // Console.WriteLine($"Hello {firstName}.");

        // Console.Write("What is your favorite color? ");
        // string favoriteColor = Console.ReadLine();

        // Console.WriteLine($"{firstName}Your favorite color is {favoriteColor}");

        // Console.Write("How old are you? ");
        // int age = int.Parse(Console.ReadLine());

        // Console.WriteLine($"{firstName} you are {age} years old.");

        // int a = 13;
        // int b = 7;

        // int c = a + b;



        // double x = 1.5;
        // float y = 1.5f;

        // bool isDone = false;
        // if (isDone) 
        // {
        //     Console.WriteLine("All done.");
        // }
        // else
        // {
        //     Console.WriteLine("Not done yet.");
        // }
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}