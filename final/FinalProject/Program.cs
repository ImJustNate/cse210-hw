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

        player1.SelectHand([]);

        
            int roundCounter = 1;

            magicWizard.DisplayRoundCounter(roundCounter);
            magicWizard.DisplayBattleField();

        while(opponent.HasHand() && player1.HasHand()){
            tracker.Fight(player1.SelectCard(), opponent.SelectCard(boss.PlayStyle()), roundCounter);
            roundCounter ++;
        }
        player1.DisplayHandSelectionList();
        
        
    }
}
