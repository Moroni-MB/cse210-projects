using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for today?",
        "What challenged me the most today?",
        "What is something I learned today—about myself or someone else?",
        "What was something that made me smile or laugh today?",
        "How did I make someone else’s day better?",
        "What scripture or gospel principle stood out to me today?",
        "How did I feel the Spirit guide me today?",
        "What prayer was answered today?",
        "How did I serve someone today, and how did it make me feel?",
        "What blessing from God did I notice that I might have missed before?",
        "What emotion surprised me today, and why?",
        "What did I do to take care of my mental or emotional health today?",
        "What’s something I handled well today that I might have struggled with before?",
        "What thought or worry did I let go of today?",
        "How would I describe my overall mood today in one word, and why?",
        "What’s one small step I took toward one of my goals today?",
        "What’s something I could do tomorrow to improve myself?",
        "What is one habit I want to build or strengthen this week?",
        "Did I use my time wisely today? Why or why not?",
        "If I could accomplish one thing tomorrow, what would it be?",
        "If today were a chapter in a book, what would its title be?",
        "Describe a moment from today as if you were telling it to your future self.",
        "What color or song would best describe how today felt?",
        "If I could freeze one moment from today forever, what would it be?",
        "What advice would I give to myself at the start of today?"
    };
    public Random _random = new Random();

    public string GetPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}