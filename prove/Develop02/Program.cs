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

        string x = "";
        while (x != "6"){
            Console.WriteLine("Your options are:\n 1. Write a new entry\n 2. Display the journal\n 3. Save the journal to a file\n 4. Load the journal from a file\n 5. Change name\n 6. End program");
            x = Console.ReadLine();
            Console.WriteLine(x);

            Journal journal = new();

            Entry entry = new();

            if (x == "1")
            {
                        
                List<string> Prompts = new() {
                "Describe a recent dream in detail.",
                "Write about a memory from childhood that has stayed with you.",
                "What is your biggest fear, and why does it scare you?",
                "If you could have any superpower, what would it be and why?",
                "What is your biggest regret, and what have you learned from it?",
                "Write about a time when you felt most alive.",
                "What is your biggest hope for the future?",
                "What is your biggest accomplishment, and how did it make you feel?",
                "Write about a time when you felt most loved.",
                "What is your biggest challenge right now, and how are you overcoming it?",
                "Describe your ideal day.",
                "Write about a person who has had a significant impact on your life.",
                "What is your biggest dream, and what are you doing to make it happen?",
                "Write about a time when you felt most grateful.",
                "What is your biggest regret, and what would you do differently if you could go back in time?",
                "Describe your biggest fear, and how you are overcoming it.",
                "What is your biggest hope for the future, and what are you doing to make it happen?",
                "Write about a time when you felt most alive.",
                "What is your biggest accomplishment, and how did it make you feel?",
                "Write about a time when you felt most loved.",
                "What is your biggest challenge right now, and how are you overcoming it?",
                "Describe your ideal day.",
                "Write about a person who has had a significant impact on your life.",
                "What is your biggest dream, and what are you doing to make it happen?",
                "Write about a time when you felt most grateful.",
                "What is your biggest regret, and what would you do differently if you could go back in time?",
                "Describe your biggest fear, and how you are overcoming it.",
                "What is your biggest hope for the future, and what are you doing to make it happen?",
                "Write about a time when you felt most alive."
                };

                Random random = new();
                int randomIndex = random.Next(Prompts.Count);
                string randomPrompt = Prompts[randomIndex];  
                // generates random prompt



                entry._date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                Console.WriteLine("What is your name?");
                entry._name = Console.ReadLine();
                entry._prompt = randomPrompt;
                Console.Write(entry._prompt);
                entry._note = Console.ReadLine();

                entry.Note();
                journal._journal.Append(entry._entry);

            }
            else if( x == "2"){
                foreach (string temp_entry in journal._journal){
                Console.WriteLine(temp_entry);
                }
                // Console.WriteLine(entry._entry);
                Console.WriteLine("end the world");

            }
            else if( x == "3"){
                journal.Save();
            }

            else
            {
                break;
            }
        }

        


    }
}