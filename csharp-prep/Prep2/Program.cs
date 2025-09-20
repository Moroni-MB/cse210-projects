using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int GradePercentage = int.Parse(Console.ReadLine());
        string letter = "";
        if (GradePercentage >= 90)
        {
            letter = "A";
        }
        else if (GradePercentage >= 80)
        {
            letter = "B";
        }
        else if (GradePercentage >= 70)
        {
            letter = "C";
        }
        else if (GradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (GradePercentage >= 70)
        {
            Console.WriteLine("Congratulations for passing the class!");
        } else {
            Console.WriteLine("I'm sorry, you didn't pass the class. Reach out to Academic Advising for more help!");
        }
    }
}