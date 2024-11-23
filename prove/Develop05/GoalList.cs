public class GoalList 
{
    private int _pointValue  = 0;
    private string _location = "WeirdFileNameSoIDontMatchOthers.txt";
    List<Goals> _theGoals = [];
    // private string _txtFile;

    public void GetTotalPoints(){
        Console.WriteLine($"You have {_pointValue} points");
    }

    public void AppendToGoals(Goals goal1){
        _theGoals.Add(goal1);
    }

    public void Display( bool isChecklist = true){
        if (isChecklist){
            foreach (Goals goal in _theGoals){
                Console.WriteLine($"{goal.DisplayGoal()}");
            }
        }
        else{
            int x = 0;
            foreach (Goals goal in _theGoals){
                x++;
                Console.WriteLine($"{x}. {goal.DisplayGoal()}");
            }
        }

    }
    
    public void Save()
    {
    using (StreamWriter outputFile = new StreamWriter(_location))
    {
        // You can add text to the file with the WriteLine method
        // outputFile.WriteLine(_journal);
            outputFile.WriteLine($"{_pointValue}");
        foreach (Goals goal in _theGoals){
            outputFile.WriteLine($"{goal.ReturnGoal()}");
        }
    }
    }
    
    public int Load()
    {
        string[] lines = [];

        try
        {
            lines = System.IO.File.ReadAllLines(_location);
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("There are no previously saved and easily accessible goals on you computer. Would you like to use our premade goals? (Y/N)");
            string answer = Console.ReadLine();
                if (answer == "Y"){
                    using (StreamWriter outputFile = new StreamWriter(_location))
                    outputFile.WriteLine($"5\nSG|Eat breakfast|Eat A healthy breakfast this includes a protein, a produce, and a carb|5|false\nEG|Read Scriptures|Minimum of 15 min|10");
                    return 1;
                }
                else{
                    Console.WriteLine("Alright feel free to make some new goals then!");
                    return 2;
                }
        }
            int x = 0;

            foreach (string line in lines)
            {   
                if (x == 0){
                    x = 16;
                    _pointValue += Convert.ToInt32(line);
                }
                else{
                    // Console.WriteLine(line);
                    List<string> wordPart = new(line.Split('|'));
                    if (wordPart[0] == "SG"){
                        Simple AGoal = new();
                        AGoal.NewGoalForGoalList(wordPart[1], wordPart[2], Convert.ToInt32(wordPart[3]), Convert.ToBoolean(wordPart[4]));
                        _theGoals.Add(AGoal);
                    }
                    else if (wordPart[0] == "EG"){
                        Eternal AGoal = new();
                        AGoal.NewGoalForGoalList(wordPart[1], wordPart[2], Convert.ToInt32(wordPart[3]));
                        _theGoals.Add(AGoal);
                    }
                    else if (wordPart[0] == "CG"){
                        Checklist AGoal = new();
                        AGoal.NewGoalForGoalList(wordPart[1], wordPart[2], Convert.ToInt32(wordPart[3]), true, Convert.ToInt32(wordPart[4]), Convert.ToInt32(wordPart[5]), Convert.ToInt32(wordPart[6]));
                        _theGoals.Add(AGoal);
                    }
                }
                // _theGoals.Add(line);
            }
        
            return 3;
    }

    public void CompleteGoal(int chosenGoal){
        _pointValue += _theGoals[chosenGoal].CompleteGoal();
    }
}