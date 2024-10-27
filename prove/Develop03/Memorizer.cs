using System.Data.Common;

class Memorizer
{
    private string _heading = "The Book Of Mormon \nsecret edition";
    private List<Word> _hidableText = new();


    public void SplitScripture(string heading, string scripture)
    {
        _heading = heading;

        List<String> Text = new();
        string[] words = scripture.Split(' ');
                
        foreach (string prt in words){
            // Console.WriteLine(prt);
            Word temp = new();
            temp.SetWordText(prt);
            _hidableText.Add(temp);
        }

    }

    public void SplitScripture(string scripture)
    {
        List<String> Text = new();
        string[] words = scripture.Split(' ');
                
        foreach (string prt in words){
            // Console.WriteLine(prt);
            Word temp = new();
            temp.SetWordText(prt);
            _hidableText.Add(temp);
        }

    }

    public void HideWords()
    {
        int hiddenWords = 0;

        while (hiddenWords < 3 && CompletelyHidden())
        {
            // random word selector
            Random random = new();
            int randomIndex = random.Next(_hidableText.Count);
            Word randomWord = _hidableText[randomIndex];
            
            if (randomWord.IsNotHidden()){
                randomWord.Hide();
                hiddenWords +=1;
            }
        }

    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_heading);
        foreach (Word prt in _hidableText){
            Console.Write($"{prt.GetWordText()} ");
        }

    }

    public bool CompletelyHidden()
    {
        // bool notHidden = true;
        foreach (Word prt in _hidableText){
            if (prt.IsNotHidden()){
                return true;
            }
        }
        return false;
    }
    
}