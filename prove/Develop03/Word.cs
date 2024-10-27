using System.Data.Common;

class Word
{
    //atrebute (member varibales)
    private string _wordText;
    private bool _isNotHidden;


    public void SetWordText(string word) 
    {
        _wordText = word;
        _isNotHidden = true;
    }

    public string GetWordText() 
    {
        return _wordText;
    }

    
    public bool IsNotHidden() 
    {
        return _isNotHidden;
    }
    
    public void Hide() 
    {
        _wordText = "_____";
        _isNotHidden = false;
    }
    
}