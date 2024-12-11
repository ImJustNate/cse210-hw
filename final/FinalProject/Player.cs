class Player : Person{
    private Animation _magicWizard = new();
    // private List<string> _car = [];

    public override void SelectHand(List<string> hobo){
        _hand = [new(ConsoleKey.F3), new(ConsoleKey.F3), new(ConsoleKey.F3)];

        Console.WriteLine("SELECT 3 CARDS TO MAKE UP YOUR HAND");
        _magicWizard.DisplayOptions();
        DisplayOnlyHand();
        ConsoleKeyInfo prepCard = Console.ReadKey();
        Card card1 = new(prepCard.Key);
        _hand[0] = card1;
        
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("SELECT 3 CARDS TO MAKE UP YOUR HAND");
        _magicWizard.DisplayOptions();
        DisplayOnlyHand();
        ConsoleKeyInfo prepCard2 = Console.ReadKey();
        Card card2 = new(prepCard2.Key);
        _hand[1] = card2;

        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("SELECT 3 CARDS TO MAKE UP YOUR HAND");
        _magicWizard.DisplayOptions();
        DisplayOnlyHand();
        ConsoleKeyInfo prepCard3 = Console.ReadKey();
        Card card3 = new(prepCard3.Key);
        _hand[2] = card3;

        Thread.Sleep(100);
        Console.Clear();

        // _hand[1].Loss(); // testing only delete later!
        _magicWizard.DisplayContinueHand();
        DisplayOnlyHand();

        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();

    }

    public void DisplayHandSelectionList(){

        for (int i = 0; i < 18 ; i++) {
            
            Console.WriteLine("{0,53}{1,53}{2,53}",
                _hand[0].ReturnAnimationList()[i],
                _hand[1].ReturnAnimationList()[i],
                _hand[2].ReturnAnimationList()[i]
                );
            if (i == 0){
                Console.WriteLine("{0,53}{1,53}{2,53}",
                "|          Press 1 to select this card          |",
                "|          Press 2 to select this card          |",
                "|          Press 3 to select this card          |"
                    );
                i++;
            }
        }

    }

    public void DisplayOnlyHand(){
        for (int i = 0; i < 18 ; i++) {
            
            Console.WriteLine("{0,53}{1,53}{2,53}",
                _hand[0].ReturnAnimationList()[i],
                _hand[1].ReturnAnimationList()[i],
                _hand[2].ReturnAnimationList()[i]
                );
        }

    }

    public override Card SelectCard(string Car = "car"){
        DisplayHandSelectionList();
        ConsoleKey selectedCard = Console.ReadKey().Key;
          while(true){
            if (selectedCard == ConsoleKey.D1){
                if (_hand[0].IsAlive()){
                    return _hand[0];
                    }
            }
            if (selectedCard == ConsoleKey.D2){
                if (_hand[1].IsAlive()){
                    return _hand[1];
                    }
            }
            if (selectedCard == ConsoleKey.D3){
                if (_hand[2].IsAlive()){
                    return _hand[2];
                    }
            }
            
            Console.Clear();
            Console.WriteLine("Improper input please try again");
            DisplayHandSelectionList();
            selectedCard = Console.ReadKey().Key;
            
          }

    }


}