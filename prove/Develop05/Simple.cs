 class Simple : Goals
{
    private bool _isCompleted  = false;

    public override  int SetPointValue(){
        Console.WriteLine($"How many points is {_goalName} worth?");
        string tempString = Console.ReadLine();
        int tempNum = Convert.ToInt32(tempString);
        return tempNum;
    }
    public override void NewGoalForGoalList(string name, string description, int points, bool completed = true, int isCompleted = 0, int timesToComplete = 0, int bonus = 0){
    _goalName = name;
    _goalDescription = description;
    _pointValue = points;
    _isCompleted = completed;
    }
    public override int CompleteGoal(){
        _isCompleted = true;
        Console.WriteLine($"Nice job here are {_pointValue} points for completing {_goalName}");
        return _pointValue;

    }

    public bool isCompleted(){
        return _isCompleted;
    }
    public override string ReturnGoal(){
        return $"SG|{_goalName}|{_goalDescription}|{_pointValue}|{_isCompleted}";
    }
    public override string DisplayGoal(){
        if (_isCompleted){
            return $"[X] {_goalName} ({_goalDescription})";
        }
        else{
            return $"[ ] {_goalName} ({_goalDescription})";   
        }
    }

}