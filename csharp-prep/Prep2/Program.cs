using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_str = Console.ReadLine();
        int grade_int = int.Parse(grade_str);


        if (grade_int >= 90)
        {
            Console.WriteLine("Grade is A");
            Console.WriteLine("You passed Yah!");
        }
        else if (grade_int >= 80)
        {
            Console.WriteLine("Grade is B");
            Console.WriteLine("You passed Yah!");
        }
        else if (grade_int >= 70)
        {
            Console.WriteLine("Grade is C");
            Console.WriteLine("You passed Yah!");
        }
        else if (grade_int >= 60)
        {
            Console.WriteLine("Grade is D");
            Console.WriteLine("You failed, Try again next semester");
        }
        else
        {
            Console.WriteLine("Grade is F");
            Console.WriteLine("You failed, Try again next semester");
        }
}
}