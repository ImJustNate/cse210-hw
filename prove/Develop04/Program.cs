using System;

class Program
{
    static void Main(string[] args)
    {

        string response = "0";
        
        while (true)
        {
            Console.WriteLine("Menu Options: \n\t1. Start breathing activity\n\t2. Start reflection activity\n\t3. Start listing activity\n\t4. Quit");
            response = Console.ReadLine();

            if (response == "1"){
                Breathing act1 = new("name");
                act1.BreathingActivity();
            }
            else if (response == "2"){
                Reflection act2 = new("name");
                act2.ReflectionActivity();
            }
            else if (response == "3"){
                Listing act3 = new("name");
                act3.ListingActivity();
            }
            else if (response == "4"){
                break;
            }
            else if (response == "5"){
                Console.Write("This is a secret message for you if you doubt my implementation on this asignment");
                Thread.Sleep(700);
                Console.Write("\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");
                Thread.Sleep(700);
                Console.Write("a");
                Thread.Sleep(700);
                Console.Write("s");
                Thread.Sleep(700);
                Console.Write("s");
                Thread.Sleep(700);
                Console.Write("i");
                Thread.Sleep(700);
                Console.Write("g");
                Thread.Sleep(700);
                Console.Write("n");
                Thread.Sleep(700);
                Console.Write("m");
                Thread.Sleep(700);
                Console.Write("e");
                Thread.Sleep(700);
                Console.Write("n");
                Thread.Sleep(700);
                Console.Write("t");
                Thread.Sleep(3000);
                Console.Clear();
                Console.Write("Go away!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.Write("I can wait");
                Thread.Sleep(3000);
                Console.Clear();
                Console.Write("No really I can!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.Write("fine back to the menu with you!");
                Console.Clear();
            }
            else{
                Console.WriteLine("Improper input please select options 1-4.");
            }
        }
    }
}