using System.Data.Common;

class Reference
{
    //attribute (member variables)
    public string _heading;
    public string _text;


    public void SetScripture(){
        _heading = "Ether 12:27";
        _text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
    }

    public void SetScripture(string heading, string text){
        _heading = heading;
        _text = text;
    }

    public string GetHeading(){
        return _heading;
    }

    public string GetScripture(){
        return _text;
    }

    public void DisplayScripture(){
        Console.Clear();
        Console.WriteLine($"{_heading} \n{_text}");
    }



}