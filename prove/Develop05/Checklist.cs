class Checklist : Goals
{

    public override  int SetPointValue(){
        Console.WriteLine("yes");
        return 101;
    }
    public override void CompleteGoal(){
        Console.WriteLine("no");

    }

}