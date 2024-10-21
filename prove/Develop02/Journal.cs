using System.Data.Common;
using System.IO; 


class Journal
{
    
    public List<String> _journal = new();
    public string _fileName = "myFile.txt";



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


        foreach (string line in lines)
        {
            _journal.Add(line);
        }
    }
}