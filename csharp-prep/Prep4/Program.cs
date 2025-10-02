using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> user_list = new List<int>();
        int stop_number = 1;
        int total_sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (stop_number == 1)
        {
            Console.Write("Enter number: ");
            int user_number = int.Parse(Console.ReadLine());
            
            if (user_number != 0) 
            {
                user_list.Add(user_number);
                total_sum += user_number;
            } else
            {
                stop_number = 0;
            }
        }
        // Console.Write(user_list.Count);
        Console.WriteLine($"The sum is: {total_sum}");

        float average = (float)total_sum / user_list.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = user_list.Max();
        Console.WriteLine($"The largest number is: {largest}");

        // int smallestPositive = user_list.
        user_list.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in user_list)
        {
            Console.Write(num);
        }

    }
}