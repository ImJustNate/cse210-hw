using System;
using System.Diagnostics;

class Reflection : Activity
{
    private List<string> _prompt = 
["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    private int _promptIndex = -5;

    private List<string> _question= 
["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", " What could you learn from this experience that applies to other situations?", " What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    private int _questionIndex = -5;

    public Reflection(string name)
        : base(name)
    {
        SetDuration();
    }

    public void ShortDescription()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string PromptSelector(){
        if (_promptIndex < 0){
            Random random = new();
            int randomIndex = random.Next(_prompt.Count);
            string randomPrompt = _prompt[randomIndex];
            _promptIndex ++;
            return randomPrompt;
        }
        else if (_promptIndex <= _prompt.Count){
            string NextPrompt = _prompt[_promptIndex];
            _promptIndex ++;
            return NextPrompt;
        }
        else{
            _promptIndex = 1;
            return _prompt[0];
        }
    }
    
    public string QuestionsSelector(){
        if (_questionIndex < 0){
            Random random = new();
            int randomIndex = random.Next(_question.Count);
            string randomQuestion = _question[randomIndex];
            _questionIndex ++;
            return randomQuestion;
        }
        else if (_questionIndex <= _question.Count){
            string nextQuestion = _question[_questionIndex];
            _questionIndex ++;
            return nextQuestion;
        }
        else{
            _questionIndex = 1;
            return _question[0];
        }
    }


    public void ReflectionActivity()
    {
        ShortDescription();
        decimal duration = GetDuration()/6;
        int x = 1;

        while(duration > 0)
        {
            if (x == 1)
            {
                string aPrompt= PromptSelector();

                Animation(1,$"{aPrompt} 6");
                Animation(1,$"{aPrompt} 5");
                Animation(1,$"{aPrompt} 4");
                Animation(1,$"{aPrompt} 3");
                Animation(1,$"{aPrompt} 2");
                Animation(1,$"{aPrompt} 1");
                x = 2;
                
                duration --;
            }
            else
            {
                string aQuestion= QuestionsSelector();

                Animation(1,$"{aQuestion} 6");
                Animation(1,$"{aQuestion} 5");
                Animation(1,$"{aQuestion} 4");
                Animation(1,$"{aQuestion} 3");
                Animation(1,$"{aQuestion} 2");
                Animation(1,$"{aQuestion} 1");

                x++;
                if (x==10)
                {
                    x = 1;
                }
                duration --;
            }
        }
        
        EndingMessage();
    }
}