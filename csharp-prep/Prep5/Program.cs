using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int squaredNumber = SquareNumber(PromptUserNumber());

        int birthYear = PromptUserBirthYear();

        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your username: ");
        string user = Console.ReadLine();
        return user;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int PromptUserBirthYear ()
    {
        Console.Write("Enter the year you were born: ");
        int year = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;

        int age = currentYear - year;

        return age;
    }

    static int SquareNumber (int a)
    {
        int squaredNumber = a * a;
        return squaredNumber;
    }

    static void DisplayResult (string username, int sqNumber, int newAge)
    {
        Console.WriteLine($"{username}, the square of your number is {sqNumber}.");
        Console.WriteLine($"{username}, you will turn {newAge} this year.");
    }
}