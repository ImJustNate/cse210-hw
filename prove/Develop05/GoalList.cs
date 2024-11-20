public class GoalList 
{
    private int _pointValue  = 100;

    public   int SetPointValue(){
        Console.WriteLine($"How many points is  worth?");
        string tempString = Console.ReadLine();
        int tempNum = Convert.ToInt32(tempString);
        return tempNum;
    }
    public void GetTotalPoints(){
        Console.WriteLine($"You have {_pointValue} points");
    }
    public  void CompleteGoal(){
        Console.WriteLine("no");

    }

    public bool isCompleted(){
        return true;
    }
}