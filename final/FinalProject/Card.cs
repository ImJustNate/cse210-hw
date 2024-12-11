using System.Linq.Expressions;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Card{
    private string _card;
    private bool _isAlive = true;
    private int _health = 2;
    private Animation _magicWizard = new();

    public Card(string cardChoice){
        while(true){
            if (cardChoice == "1"){
                _card = "Rock";
                break;
            }
            else if (cardChoice == "2"){
                _card = "Paper";
                break;
            }
            else if (cardChoice == "3"){
                _card = "Scissors";
                break;
            }
            else if (cardChoice == "win"){
                _card = "win";
                break;
            }
            else if (cardChoice == "loose"){
                _card = "loose";
                break;
            }
            else{
                Console.Clear();
                Console.WriteLine("Improper selection input! \nPlease select card options '1', '2', or '3' by typing just the number 1, 2, or 3");
                _magicWizard.DisplayOptions();
                cardChoice = Console.ReadLine();
                
    // public Card(ConsoleKeyInfo cardChoice){
    //     while(true){
    //         if (cardChoice.Key == ConsoleKey.D1){
    //             _card = "Rock";
    //             break;
    //         }
    //         else if (cardChoice.Key == ConsoleKey.D2){
    //             _card = "Paper";
    //             break;
    //         }
    //         else if (cardChoice.Key == ConsoleKey.D3){
    //             _card = "Scissors";
    //             break;
    //         }
    //         else if (cardChoice.Key == ConsoleKey.F2){
    //             _card = "win";
    //             break;
    //         }
    //         else if (cardChoice.Key == ConsoleKey.F4){
    //             _card = "loose";
    //             break;
    //         }
    //         else{
    //             Console.Clear();
    //             Console.WriteLine("Improper selection input! \nPlease select card options '1', '2', or '3' by pressing just the number 1, 2, or 3");
    //             _magicWizard.DisplayOptions();
    //             cardChoice = Console.ReadKey();
            }
        }
    }
    public void Display(){
            if (_card == "Rock"){
                _magicWizard.DisplayRock();
            }
            else if (_card == "Paper"){
                _magicWizard.DisplayPaper();
            }
            else if (_card == "Scissors"){
                _magicWizard.DisplayScissors();
            }
            else{
                Console.Clear();
                Console.WriteLine("Comense paniq ebery fing is brokted");
            
        }
    }
    public List<string> ReturnAnimationList(){
        if (!_isAlive){
            return _magicWizard.ReturnDeath();
        }
        else if (_card == "Rock"){
            return _magicWizard.ReturnRock();
        }
        else if (_card == "Paper"){
            return _magicWizard.ReturnPaper();
        }
        else if (_card == "Scissors"){
            return _magicWizard.ReturnScissors();
        }
        else{
            
            Console.Clear();
            Console.WriteLine("Comense paniq ebery fing is brokted");
        return ["oops this broke", "bad isn't it!", "yikes","","","maybe you should try again"];
        }
    }
    public bool IsAlive(){
        if (_isAlive){
            if (_health == 0){
                _isAlive = false;
                return false;
            }
            else if (_health == 1){
                return true;
            }
            else if (_health == 2){
                return true;
            }
            else {
                _isAlive = false;
                return false;
            }
        }
        else{
        return false;
        }
    }
    public void Tie(){
        _health -= 1;
        if (_health <=0){
            _isAlive = false;
        }
    }
    public void Loss(){
        
        _isAlive = false;
    }

    public string ReturnCard(){
        return _card;
    }

}