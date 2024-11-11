using System.Data.Common;

class Entry
{
    //atrebute (member varibales)
    private string _name = "1";
    private string _note;
    private string _date;
    private string _prompt;
    private string _entry;
    
    private List<string> _prompts = new() {
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


    public void Write(string name)
    {
        _name = name;

        Random random = new();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];  
        // generates random prompt


        if (_name == "1"){
            Console.WriteLine("What is your real name?");
            _name = Console.ReadLine();
        }


        _date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
        _prompt = randomPrompt;
        Console.WriteLine(_prompt);
        _note = Console.ReadLine();

        _entry = $"{_name} @ {_date}\n{_prompt}\n{_note}\n";
    }
    
    public string ReturnEntry()
    {
        return _entry;
    }
}
