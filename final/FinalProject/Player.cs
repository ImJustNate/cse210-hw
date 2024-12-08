class Player : Person{
    private Animation _magicWizard = new();
    // private List<string> _car = [];

    public override void SelectHand(List<string> hobo){
        _magicWizard.DisplayOptions();
        Card card1 = new(Console.ReadLine());
        List<string> animation1 = card1.ReturnAnimationList();
        _hand.Add(card1);
        
        Thread.Sleep(100);

        _magicWizard.DisplayOptions();
        Card card2 = new(Console.ReadLine());
        List<string> animation2 = card2.ReturnAnimationList();
        _hand.Add(card2);

        Thread.Sleep(100);

        _magicWizard.DisplayOptions();
        Card card3 = new(Console.ReadLine());
        List<string> animation3 = card3.ReturnAnimationList();
        _hand.Add(card3);

        Thread.Sleep(100);

        // _hand[1].Loss(); // testing only delete later!
        
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
                "|    Press 1 then ENTER to select this card     |",
                "|    Press 2 then ENTER to select this card     |",
                "|    Press 3 then ENTER to select this card     |"
                    );
                i++;
            }
        }

    }

    public void DisplayOnlyHand(){

        Console.WriteLine("     _________________________________________________________________________________________________________________________________________________________");
        Console.WriteLine("    |                                                                                                                                                         |");
        Console.WriteLine("    |    Your hand is made up of the following cards. Press ENTER when you are ready to continue!                                                             |");
        Console.WriteLine("    |_________________________________________________________________________________________________________________________________________________________|");
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
        string selectedCard = Console.ReadLine();
          while(true){
            if (selectedCard == "1"){
                if (_hand[0].IsAlive()){
                    return _hand[0];
                    }
            }
            if (selectedCard == "2"){
                if (_hand[1].IsAlive()){
                    return _hand[1];
                    }
            }
            if (selectedCard == "3"){
                if (_hand[2].IsAlive()){
                    return _hand[2];
                    }
            }
            
            Console.Clear();
            Console.WriteLine("Improper input please try again");
            DisplayHandSelectionList();
            selectedCard = Console.ReadLine();
            
          }

    }


}