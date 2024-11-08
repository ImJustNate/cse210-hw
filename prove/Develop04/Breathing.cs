using System;

class Breathing : Activity
{

    public Breathing(string name)
        : base(name)
    {
        SetDuration();
    }

    public void ShortDescription()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void BreathingActivity()
    {
        ShortDescription();
        decimal duration = GetDuration()/6;

        while(duration > 0)
        {
            Animation(1,"Breath in 3");
            Animation(1,"Breath in 2");
            Animation(1,"Breath in 1");

            Animation(1,"Breath out 3");
            Animation(1,"Breath out 2");
            Animation(1,"Breath out 1");
            duration --;
        }

        EndingMessage();
    }

}