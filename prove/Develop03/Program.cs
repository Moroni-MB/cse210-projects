using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Helaman", 5, 12);
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
            new Reference("Proverbs", 3, 5, 6)
        ));

        scriptures.Add(new Scripture(
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            new Reference("John", 3, 16)
        ));

        scriptures.Add(new Scripture(
            "If ye love me, keep my commandments.",
            new Reference("John", 14, 15)
        ));

        scriptures.Add(new Scripture(
            "I can do all things through Christ which strengtheneth me.",
            new Reference("Philippians", 4, 13)
        ));


        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Great job!");
                break;
            }
            
            Console.WriteLine("Welcome to the Scripture Memorizer program. Press enter to continue or type quit to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords(random);

        }
    }
}