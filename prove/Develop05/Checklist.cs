class Checklist : Goals
{
    private int _isCompleted  = 0;
    private int _timesToComplete = 5;
    private int _bonusPoints = 0;

    public override  int SetPointValue(){
        Console.WriteLine($"How many times will you complete {_goalName}?");
        string tempString = Console.ReadLine();
        _timesToComplete = Convert.ToInt32(tempString);

        Console.WriteLine($"How many points will you get each time you complete it?");
        tempString = Console.ReadLine();
        int tempNum = Convert.ToInt32(tempString);
        
        Console.WriteLine($"How many points will you get for completing {_goalName} {_timesToComplete} times?");
        tempString = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(tempString);

        return tempNum;
    }
    public override void NewGoalForGoalList(string name, string description, int points, bool completed = true, int isCompleted = 0, int timesToComplete = 0, int bonus = 0){
        _goalName = name;
        _goalDescription = description;
        _pointValue = points;
        _isCompleted = isCompleted;
        _timesToComplete = timesToComplete;
        _bonusPoints = bonus;
    }
    public override int CompleteGoal(){
        _isCompleted ++;
        int tempPointTotal = _pointValue;
        Console.WriteLine($"Nice job here are {_pointValue} points for completing {_goalName} one more time");
        if (_isCompleted == _timesToComplete){
            tempPointTotal += _bonusPoints;
            Console.WriteLine($"Nice job here are {_bonusPoints} bonus points for completing {_goalName} {_timesToComplete} times");
        }
        return tempPointTotal;

    }
    public override string ReturnGoal(){
        return $"CG|{_goalName}|{_goalDescription}|{_pointValue}|{_isCompleted}|{_timesToComplete}|{_bonusPoints}";
    }
    public override string DisplayGoal(){
        if (_isCompleted < _timesToComplete){
            return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {_isCompleted}/{_timesToComplete}";
        }
        else{
            return $"[X] {_goalName} ({_goalDescription})";   
        }
    }
}