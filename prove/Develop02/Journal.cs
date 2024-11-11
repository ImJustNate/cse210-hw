using System.Data.Common;
using System.IO; 


class Journal
{
    
    public List<String> _journal = new();
    public string _fileName = "myFile.txt";



    public void AppendEntry(string tempEntry){
        _journal.Add(tempEntry);
    }

    public void Display(){
        foreach (string thought in _journal){
            Console.WriteLine(thought);
        }

    }    

    public void Save()
    {
    using (StreamWriter outputFile = new StreamWriter("myFile.txt"))
    {
        // You can add text to the file with the WriteLine method
        // outputFile.WriteLine(_journal);
        foreach (string thought in _journal){
            outputFile.WriteLine($"{thought}");
        }
    }
    }
    
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        _journal = [];


        foreach (string line in lines)
        {
            _journal.Add(line);
        }
    }
}