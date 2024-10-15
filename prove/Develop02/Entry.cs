using System.Data.Common;

class Entry
{
    //atrebute (member varibales)
    public string _note;
    public string _date;
    public string _prompt;
    public string _name;
    public string _entry;


    public void Note()
    {
        _entry = $"{_name} {_date}\n{_prompt}\n{_note}";

    }
    
}