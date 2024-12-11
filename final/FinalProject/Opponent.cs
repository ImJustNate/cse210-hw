class Opponent : Person{
    private bool _IsUndefeated = true;
    private Animation _magicWizard = new();
    private int _livesLost = 0;
    

    public override void SelectHand(List<string> selectedHand){
        _hand = [];
        if (selectedHand[0] == "1" ||selectedHand[0] == "2" ||selectedHand[0] == "3"){
        Card card1 = new(selectedHand[0]);
        _hand.Add(card1);

        Card card2 = new(selectedHand[1]);
        _hand.Add(card2);

        Card card3 = new(selectedHand[2]);
        _hand.Add(card3);
        }
        else{
        Random random = new();
        int promptIndex = 1 + random.Next(3);
        // Console.WriteLine(promptIndex);
        Card card1 = new($"{promptIndex}");
        _hand.Add(card1);
        
        int promptIndex2 = 1 + random.Next(3);
        // Console.WriteLine(promptIndex2);
        Card card2 = new($"{promptIndex2}");
        _hand.Add(card2);

        int promptIndex3 = 1 + random.Next(3);
        // Console.WriteLine(promptIndex3);
        Card card3 = new($"{promptIndex3}");
        _hand.Add(card3);            
        }
    }
        
        //hypothetically testing only
    // public void DisplayHandSelectionList(){

    //     for (int i = 0; i < 18 ; i++) {
            
    //         Console.WriteLine("{0,53}{1,53}{2,53}",
    //             _hand[0].ReturnAnimationList()[i],
    //             _hand[1].ReturnAnimationList()[i],
    //             _hand[2].ReturnAnimationList()[i]
    //             );
    //         if (i == 0){
    //             Console.WriteLine("{0,53}{1,53}{2,53}",
    //             "|    Press 1 then ENTER to select this card     |",
    //             "|    Press 2 then ENTER to select this card     |",
    //             "|    Press 3 then ENTER to select this card     |"
    //                 );
    //             i++;
    //         }
    //     }

    // }

        //testing purposes only
    public void BossDisplayOnlyHand(){

        Console.WriteLine("     _________________________________________________________________________________________________________________________________________________________");
        Console.WriteLine("    |                                                                                                                                                         |");
        Console.WriteLine("    |    The Boss hand is made up of the following cards. Press ENTER when you are ready to continue!                                                         |");
        Console.WriteLine("    |_________________________________________________________________________________________________________________________________________________________|");
        for (int i = 0; i < 18 ; i++) {
            
            Console.WriteLine("{0,53}{1,53}{2,53}",
                _hand[0].ReturnAnimationList()[i],
                _hand[1].ReturnAnimationList()[i],
                _hand[2].ReturnAnimationList()[i]
                );
        }

    }
    public override Card SelectCard(string wayToSelectACard){
          while(true){
            if (wayToSelectACard == "rand"){
                // BossDisplayOnlyHand();
                
                Random random = new();
                while (true){
                    int promptIndex = random.Next(3);
                    if (_hand[promptIndex].IsAlive()){
                        return _hand[promptIndex];
                    }
                }
            }
            
            else if (wayToSelectACard == "complexRock"){
                if (_hand[0].IsAlive()){
                    return _hand[0];
                }
                else if (_hand[2].IsAlive()){
                    return _hand[2];
                }
                else{
                    return _hand[1];
                }
            }
            
            else if (wayToSelectACard == "win"){
                int livesLost = 0;
                foreach(Card card in _hand){
                    if(!card.IsAlive()){
                        livesLost ++;
                    }
                }
                
                if (_livesLost == livesLost){
                    Random random = new();
                    while (true){
                        int promptIndex = random.Next(3);
                        if (_hand[promptIndex].IsAlive()){
                            return _hand[promptIndex];
                        }
                    }

                }
                else{
                    _livesLost = livesLost;
                    Card win = new("win");
                    return win;
                }
            }
            
            else if (wayToSelectACard == "Loose"){
                int livesLost = 0;
                foreach(Card card in _hand){
                    if(!card.IsAlive()){
                        livesLost ++;
                    }
                }
                
                if (_livesLost >= livesLost){
                    _livesLost = livesLost;
                    Random random = new();
                    while (true){
                        int promptIndex = random.Next(3);
                        if (_hand[promptIndex].IsAlive()){
                            return _hand[promptIndex];
                        }
                    }

                }
                else{
                    _livesLost = livesLost;
                    Card loose = new("loose");
                    return loose;
                }
            }
            else {
                Console.WriteLine("Yikes bad input on card selection for the boss  rand");
                wayToSelectACard = Console.ReadLine();
            }
          }

    }
    public bool HasCards(){
        if (_hand.Count() <= 0){
            return false;
        }
        else{
            return true;
        }
    }
    public bool IsUndefeated(){
        return _IsUndefeated;
    }


}