using System.Security.Cryptography.X509Certificates;

public abstract class Goals
{
    //attribute (member variables)
    public string _goalName;
    public string _goalDescription;
    public int _pointValue;

    public void SetGoal(){
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _goalDescription = Console.ReadLine();
        _pointValue = SetPointValue();
    }

    public abstract int SetPointValue();
    public abstract int CompleteGoal();
    public abstract string ReturnGoal();
    public abstract string DisplayGoal();
    public abstract void NewGoalForGoalList(string name, string description, int points, bool completed = true, int isCompleted = 0, int timesToComplete = 0, int bonus = 0);


    public string GetGoal(){
        return $"{_goalName} \n{_goalDescription}";
    }

    public void EndingMessage(){
        Console.WriteLine("");
    }

}