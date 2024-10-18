using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraq1 = new();
        fraq1.Fractionate();
        Console.WriteLine(fraq1.GetDecimalValue());
        Console.WriteLine(fraq1.GetFractionString());
        
        Fraction fraq2 = new();
        fraq2.Fractionate(5);
        Console.WriteLine(fraq2.GetDecimalValue());
        Console.WriteLine(fraq2.GetFractionString());
        
        Fraction fraq3 = new();
        fraq3.Fractionate(3,4);
        Console.WriteLine(fraq3.GetDecimalValue());
        Console.WriteLine(fraq3.GetFractionString());
        
        Fraction fraq4 = new();
        fraq4.Fractionate(1,3);
        Console.WriteLine(fraq4.GetDecimalValue());
        Console.WriteLine(fraq4.GetFractionString());
        
    }
}