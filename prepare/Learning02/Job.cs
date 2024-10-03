class Job
{
    //atrebute (member varibales)
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;


    public void Display()
    {
        string result = "";

        result += _jobTitle;
        result += $" ({_company}) ";
        result += _startYear;
        result += "-" + _endYear;
        
        Console.WriteLine(result);

    }
}