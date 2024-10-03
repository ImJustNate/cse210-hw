using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Resume myResume = new();
        myResume._name = "Billy Joel";

        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._endYear = 2011;
        job1._startYear = 2003;

        myResume._jobs.Add(job1);


        Job job2 = new();
        job2._jobTitle ="Super visor";
        job2._company = "Microsoft";
        job2._endYear = 2020;
        job2._startYear = 2013;

        myResume._jobs.Add(job2);


        job1.Display();
        job2.Display();

        Console.WriteLine("\n\n");
        myResume.Display();
    }
}