using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Animation magicWizard = new();
        OpponentList boss = new();
        Player player1 = new();
        Opponent opponent = new();
        Scoreboard tracker = new();

        // magicWizard.DisplayDeath();
        magicWizard.DisplayHomePage();
        magicWizard.DisplayHowTo();

        opponent.SelectHand(boss.Menu());

        Console.Clear();
        player1.SelectHand([]);

        int roundCounter = 1;

        magicWizard.DisplayRoundCounter(roundCounter);
        magicWizard.DisplayBattleField();

        while(opponent.HasHand() && player1.HasHand()){
            tracker.Fight(player1.SelectCard(), opponent.SelectCard(boss.PlayStyle()), roundCounter);
            roundCounter ++;
        }
        player1.DisplayHandSelectionList();

        string opponentName = boss.ReturnName();

        if (opponent.HasHand()){
            Console.WriteLine("\t\t\t _________________________________________________________________________________________________________________________");
            Console.WriteLine("\t\t\t|                                                                                                                         |");
            Console.WriteLine("\t\t\t|                                                   You Loose!                                                            |");
            Console.WriteLine($"\t\t\t|                                              {opponentName} defeated you                                                  |");
            Console.WriteLine("\t\t\t|_________________________________________________________________________________________________________________________|");
        }
        if (player1.HasHand()){
            Console.Clear();
            
            Console.WriteLine("\t\t\t _________________________________________________________________________________________________________________________");
            Console.WriteLine("\t\t\t|                                                                                                                         |");
            Console.WriteLine("\t\t\t|                                                   You Win!                                                              |");
            Console.WriteLine($"\t\t\t|                                            You defeated {opponentName}                                                    |");
            Console.WriteLine("\t\t\t|_________________________________________________________________________________________________________________________|");
        }
        
        
    }
}
