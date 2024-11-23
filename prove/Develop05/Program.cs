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
                Console.WriteLine("Would you like to \n 1. Create a simple goa\n 2. Create a eternal goal\n 3. Create a checklist goal");
                string chooser = Console.ReadLine();

                    if (chooser == "1"){
                        Console.WriteLine("this is option a");
                        break;
                    }
                    else if (chooser == "2"){
                        Console.WriteLine("this is option b");
                        break;
                    }
                    else if (chooser == "3"){
                        Console.WriteLine("this is option c");
                        break;
                    }
                    else{
                        Console.WriteLine("Please try it again");
                    }
                }
            Console.WriteLine("this was option 1");
            Thread.Sleep(1000);
            Console.Clear();
            }

            // If 2 (List Goals){
            else if (x == "2"){
            // DisplayGoals()
            Console.WriteLine("this is option 2");
            Thread.Sleep(1000);
            Console.Clear();
            }

            // If 3 (Save Goals){
            else if (x == "3"){
            // SaveGoals()
            Console.WriteLine("this is option 3");
            Thread.Sleep(1000);
            Console.Clear();
            }

            // If 4 (Load Goals){
            else if (x == "4"){
            // LoadGoals()
            Console.WriteLine("this is option 4");
            Thread.Sleep(1000);
            Console.Clear();
            }

            // If 5 (record Event){
            else if (x == "5"){
            // ListGoals()
            // CompleteGoal()
            // EndingMessage()
            Console.WriteLine("this is option 5");
            Thread.Sleep(1000);
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