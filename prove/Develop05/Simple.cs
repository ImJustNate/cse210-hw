 class Simple : Goals
{
    private bool _isCompleted  = false;

    public override  int SetPointValue(){
        Console.WriteLine($"How many points is {_goalName} worth?");
        string tempString = Console.ReadLine();
        int tempNum = Convert.ToInt32(tempString);
        return tempNum;
    }
    public override void CompleteGoal(){
        Console.WriteLine("no");

    }

    public bool isCompleted(){
        return _isCompleted;
    }
}