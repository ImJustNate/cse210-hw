using System;
using System.Data;

class Activity{
    private string _name;
    private int _duration;

    public Activity(string name){
        _name = name;
    }

    public void SetDuration(){
        Console.WriteLine("Welcome to MindHaven please input the amount of time in seconds that you have to meditate:\n");
        string temp = Console.ReadLine();
        _duration = int.Parse(temp);
}

    public int GetDuration(){
        return _duration;
    }

    public void EndingMessage()
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("good job");
        Thread.Sleep(1000);
        Console.Clear();
    }    
    public void Animation(int seconds, string message){
        seconds = seconds /2;

        while (seconds >= 0)
        {
            Console.Clear();
            Console.WriteLine($"{message} |  |");
            Thread.Sleep(170);

            Console.Clear();
            Console.WriteLine($"{message} \\  /");
            Thread.Sleep(170);

            Console.Clear();
            Console.WriteLine($"{message} -- --");
            Thread.Sleep(320);

            Console.Clear();
            Console.WriteLine($"{message} /  \\");
            Thread.Sleep(170);

            Console.Clear();
            Console.WriteLine($"{message} |  |");
            Thread.Sleep(170);

            seconds --;
        }
    }
}