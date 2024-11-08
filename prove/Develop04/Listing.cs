using System;
using System.Diagnostics;

class Listing : Activity
{
    private List<string> _prompt = 
    ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    private List<string> _answers = [];

    private string _selectedPrompt = "ugly";


    public Listing(string name)
        : base(name)
    {
        SetDuration();
    }

    public void ShortDescription()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void PromptSelector(){
        if (_selectedPrompt == "ugly"){
            Random random = new();
            int promptIndex = random.Next(_prompt.Count);
            _selectedPrompt = _prompt[promptIndex];
        }
        else{
            Console.WriteLine("your code is broken in live 24 of the listing class");
        }
    }


    public void ListingActivity()
    {
        ShortDescription();
        double duration = GetDuration();
        PromptSelector();

        string aPrompt = $"Get Ready...\n\nList as many responses you can to the following prompt:\n --- {_selectedPrompt} ---";

        Animation(1,$"{aPrompt} \nYou may begin in: 3");
        Animation(1,$"{aPrompt} \nYou may begin in: 2");
        Animation(1,$"{aPrompt} \nYou may begin in: 1");
        Console.Clear();
        Console.WriteLine(aPrompt);
                    
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            string answer = Console.ReadLine();
            _answers.Add(answer);
            currentTime = DateTime.Now;
        }        
        Console.Clear();
        Console.WriteLine($"You answered {_answers.Count()} times");
        Thread.Sleep(3000);
        
        EndingMessage();

    }
}