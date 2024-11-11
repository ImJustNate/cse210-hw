using System;
using System.ComponentModel.Design;

class Program
{
    
    static void Main(string[] args)
    {

        // List<string> Prompts = new() {
        // "Describe a recent dream in detail.",
        // "Write about a memory from childhood that has stayed with you.",
        // "What is your biggest fear, and why does it scare you?",
        // "If you could have any superpower, what would it be and why?",
        // "What is your biggest regret, and what have you learned from it?",
        // "Write about a time when you felt most alive.",
        // "What is your biggest hope for the future?",
        // "What is your biggest accomplishment, and how did it make you feel?",
        // "Write about a time when you felt most loved.",
        // "What is your biggest challenge right now, and how are you overcoming it?",
        // "Describe your ideal day.",
        // "Write about a person who has had a significant impact on your life.",
        // "What is your biggest dream, and what are you doing to make it happen?",
        // "Write about a time when you felt most grateful.",
        // "What is your biggest regret, and what would you do differently if you could go back in time?",
        // "Describe your biggest fear, and how you are overcoming it.",
        // "What is your biggest hope for the future, and what are you doing to make it happen?",
        // "Write about a time when you felt most alive.",
        // "What is your biggest accomplishment, and how did it make you feel?",
        // "Write about a time when you felt most loved.",
        // "What is your biggest challenge right now, and how are you overcoming it?",
        // "Describe your ideal day.",
        // "Write about a person who has had a significant impact on your life.",
        // "What is your biggest dream, and what are you doing to make it happen?",
        // "Write about a time when you felt most grateful.",
        // "What is your biggest regret, and what would you do differently if you could go back in time?",
        // "Describe your biggest fear, and how you are overcoming it.",
        // "What is your biggest hope for the future, and what are you doing to make it happen?",
        // "Write about a time when you felt most alive."
        // };

        // Random random = new();
        // int randomIndex = random.Next(Prompts.Count);
        // string randomPrompt = Prompts[randomIndex];  
        // // generates random prompt

        Journal journal = new();
        string x = "";
        string setName = "1";

        Console.WriteLine("What is your name?");
        setName = Console.ReadLine();

        while (x != "6"){
            Console.WriteLine("Your options are:\n 1. Write a new entry\n 2. Display the journal\n 3. Save the journal to a file\n 4. Load the journal from a file\n 5. Change name\n 6. End program");
            x = Console.ReadLine();
            Console.WriteLine(x);


            Entry entry = new();

            if (x == "1")
            {
                Entry entry1 = new();
                entry1.Write(setName);
                journal.AppendEntry(entry1.ReturnEntry());
            }
            else if( x == "2")
            {
                journal.Display();
            }

            else if( x == "3"){
                journal.Save();
            }

            else if( x == "4"){
                journal.Load();
            }

            else if( x == "5"){
                Console.WriteLine($"Your name is {setName}. \nWhat would you like your name to be now?");
                setName = Console.ReadLine();
            }

            else
            {
                break;
            }
        }

        


    }
}