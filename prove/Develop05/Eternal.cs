class Eternal : Goals
{

    public override  int SetPointValue(){
        Console.WriteLine($"How many points is {_goalName} worth each time it is completed?");
        string tempString = Console.ReadLine();
        int tempNum = Convert.ToInt32(tempString);
        return tempNum;
    }
    public override void NewGoalForGoalList(string name, string description, int points, bool completed = true, int isCompleted = 0, int timesToComplete = 0, int bonus = 0){
    _goalName = name;
    _goalDescription = description;
    _pointValue = points;
    }

    public override int CompleteGoal(){
        Console.WriteLine($"Nice job here are {_pointValue} points for completing {_goalName}");
        return _pointValue;
    }
    
    public override string ReturnGoal(){
        return $"EG|{_goalName}|{_goalDescription}|{_pointValue}";
    }
    public override string DisplayGoal(){
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    

}