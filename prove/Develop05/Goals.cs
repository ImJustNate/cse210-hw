public abstract class Goals
{
    //attribute (member variables)
    public string _goalName;
    public string _goalDescription;
    public int _pointValue;

    public Goals(){
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _goalDescription = Console.ReadLine();
        _pointValue = SetPointValue();
    }

    public abstract int SetPointValue();
    public abstract void CompleteGoal();


    public string GetGoal(){
        return $"{_goalName} \n{_goalDescription}";
    }

    public void EndingMessage(){
        Console.WriteLine("");
    }

}