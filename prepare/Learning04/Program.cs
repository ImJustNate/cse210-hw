using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment school = new();
        Console.WriteLine(school.GetSummery(1));


        // Now create the derived class assignments
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummery());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment eng = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(eng.GetSummery());
        Console.WriteLine(eng.GetWritingInformation());
    }
    
}