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
        outputFile.WriteLine(_journal);
    }
    }
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}