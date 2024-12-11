class Scoreboard{
    private Animation _magicWizard = new();
    
    private List<string> _rock;
    private List<string> _paper;
    private List<string> _scissors;
    
    public Scoreboard(){
        _rock = _magicWizard.ReturnRock();
        _paper= _magicWizard.ReturnPaper();
        _scissors = _magicWizard.ReturnScissors();
    }
    public string Fight(Card playerCard, Card opponentCard, int roundCounter){
        string outcome;

        if (playerCard.ReturnCard() == opponentCard.ReturnCard()){
            outcome = "Tie ";
            playerCard.Tie();
            opponentCard.Tie();
        }
        else if (playerCard.ReturnCard()== "Rock" && opponentCard.ReturnCard()== "Paper"){
            outcome = "Loss";
            playerCard.Loss();
        }
        else if (playerCard.ReturnCard()== "Rock" && opponentCard.ReturnCard()== "Scissors"){
            outcome = "Win ";
            opponentCard.Loss();
        }
        else if (playerCard.ReturnCard()== "Paper" && opponentCard.ReturnCard()== "Scissors"){
            outcome = "Loss";
            playerCard.Loss();
        }
        else if (playerCard.ReturnCard()== "Paper" && opponentCard.ReturnCard()== "Rock"){
            outcome = "Win ";
            opponentCard.Loss();
        }
        else if (playerCard.ReturnCard()== "Scissors" && opponentCard.ReturnCard()== "Rock"){
            outcome = "Loss";
            playerCard.Loss();
        }
        else if (playerCard.ReturnCard()== "Scissors" && opponentCard.ReturnCard()== "Paper"){
            outcome = "Win ";
            opponentCard.Loss();
        }
        else if (opponentCard.ReturnCard()== "win"){
            if (playerCard.ReturnCard()== "Paper"){
                Card scissors = new(ConsoleKey.D1);
                return Fight(playerCard, scissors, roundCounter);
            }
            else if (playerCard.ReturnCard()== "Rock"){
                Card paper = new(ConsoleKey.D2);
                return Fight(playerCard, paper, roundCounter);
            }
            else{
                Card rock = new(ConsoleKey.D3);
                return Fight(playerCard, rock, roundCounter);
            }
        }
        else if (opponentCard.ReturnCard()== "loose"){
            outcome = "Win ";
            opponentCard.Loss();
        }
        else{
            outcome = "rut ro raggie!";
        }



        List<string> outcomePage = [
        " _______________________________________________ ",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        $"|                   {outcome}                        |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|_______________________________________________|" 
        ];

        Console.Clear();
        
        
        _magicWizard.DisplayRoundCounter(roundCounter);

        for (int i = 0; i < 18 ; i++) {
            
            Console.WriteLine("{0,53}{1,53}{2,53}",
                playerCard.ReturnAnimationList()[i],
                outcomePage[i],
                opponentCard.ReturnAnimationList()[i]
                );
        }
        
        return outcome;
    }
}