using System;

class Program
{
    static void Main(string[] args)
    {
        GoalList Goals = new();

        //Menu
        
        while (true){
            Goals.GetTotalPoints();

            Console.WriteLine("Would you like to \n 1. Create a new goal\n 2. Display the goals?\n 3. Save the goals to a file\n 4. Load the goals from a file\n 5. Record an event \n 6. Quit");
            string x = Console.ReadLine();

            // If 1 (Create New Goal){
            if (x == "1"){
                //     // If 1 simple.SetGoal()
                //     // If 2 eternal.SetGoal()
                //     // If 3 checklist.SetGoal()
                // For all AppendToGoals()
                while(true){
                    Console.WriteLine("Would you like to \n 1. Create a simple goal\n 2. Create a eternal goal\n 3. Create a checklist goal");
                    string chooser = Console.ReadLine();

                        if (chooser == "1"){
                            Simple newGoal = new();
                            newGoal.SetGoal();
                            Console.WriteLine(newGoal.ReturnGoal());
                            Goals.AppendToGoals(newGoal);
                            break;
                        }
                        else if (chooser == "2"){
                            Eternal newGoal = new();
                            newGoal.SetGoal();
                            Console.WriteLine(newGoal.ReturnGoal());
                            Goals.AppendToGoals(newGoal);
                            break;
                        }
                        else if (chooser == "3"){
                            Checklist newGoal = new();
                            newGoal.SetGoal();
                            Console.WriteLine(newGoal.ReturnGoal());
                            Goals.AppendToGoals(newGoal);
                            break;
                        }
                        else{
                            Console.WriteLine("Please try it again");
                        }
                    }
                Thread.Sleep(1000);
                Console.Clear();
            }

            // If 2 (List Goals){
            else if (x == "2"){
            Goals.Display();
            
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            }

            // If 3 (Save Goals){
            else if (x == "3"){
            // SaveGoals()
            Goals.Save();
            Console.Write("Saving.");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Clear();
            }

            // If 4 (Load Goals){
            else if (x == "4"){
            // LoadGoals()
            int newGoalMade = Goals.Load();
            
            if (newGoalMade == 1){
                Goals.Load();
            }
            else if (newGoalMade == 2)
                break;

            Goals.Display();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            }

            // If 5 (record Event){
            else if (x == "5"){
            // ListGoals()
            // CompleteGoal()
            // EndingMessage()
            Console.WriteLine("Which goal would you like to complete?");
            Goals.Display(false);
            string tempString = Console.ReadLine();
            int chosenGoal = Convert.ToInt32(tempString) - 1;

            Goals.CompleteGoal(chosenGoal);
            
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            }

            // If 6 (quit){
            else if (x == "6"){
                break;
            }

            else{
                Console.Clear();
                Console.WriteLine("Please try it again");
            }
        }

    }
}