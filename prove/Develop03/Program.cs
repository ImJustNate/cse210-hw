using System;

class Program
{

    static void Main(string[] args)
    {
        Reference scripture = new();
        string _answer = "fay-quo";

        Console.WriteLine("Press ENTER to continue with a pregenerated scripture or enter a scripture reference to use your own");
        string scriptureReference = Console.ReadLine();

        if (scriptureReference.Length >= 5)
        {
            Console.WriteLine("What would you like the body of the scripture you would to memorize to say?");
            string scriptureBody = Console.ReadLine();
            scripture.SetScripture(scriptureReference, scriptureBody);

        }
        else
        {
            scripture.SetScripture();
        }

        Memorizer silly = new();
        silly.SplitScripture(scripture.GetHeading(), scripture.GetScripture());
        silly.Display();
        Console.WriteLine("\n\nPress ENTER to continue or type 'quit' to finnish:");

        while (silly.CompletelyHidden() && _answer != "quit")
        {
            _answer = (Console.ReadLine()).ToLower();
            silly.HideWords();
            silly.Display();
            Console.WriteLine("\n\nPress ENTER to continue or type 'quit' to finnish:");

        }

    }
}