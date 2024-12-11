using System.Reflection.Metadata.Ecma335;

class OpponentList{
    public List<List<string>> _LucyKyn = 
        [["D1", "D2", "D3"], ["Loose"]];
    public List<List<string>> _OrigamiMan = 
        [["D2", "D2", "D2"], ["rand"]];
    public List<List<string>> _LandSlide = 
        [["D1", "D1", "D3"], ["complexRock"]];
    public List<List<string>> _Radium = 
        [["random"], ["rand"]];
    public List<List<string>> _CheaterFace = 
        [["random"], ["win"]];
    private string _playStyle = "";
    private string _name;

    public List<string> Menu(){
        while (true){
            Console.WriteLine(  "Which boss would you like to fight? \n"+
                                "Press 1 to select Lucy Kyn\n"          +
                                "Press 2 to select Origami Man\n"       +
                                "Press 3 to select The Land Slide\n"    +
                                "Press 4 to select Radium\n"            +
                                "Press 5 to select Cheater Face\n");
            ConsoleKey chosenBoss = Console.ReadKey().Key;
            

            if (chosenBoss == ConsoleKey.D1){
                _playStyle = _LucyKyn[1][0];
                _name = "  Lucy Kyn  ";
                return _LucyKyn[0];
            }
            else if (chosenBoss == ConsoleKey.D2){
                _playStyle = _OrigamiMan[1][0];
                _name = " Origami Man";
                return _OrigamiMan[0];
            }
            else if (chosenBoss == ConsoleKey.D3){
                _playStyle = _LandSlide[1][0];
                _name = " Land Slide ";
                return _LandSlide[0];
            }
            else if (chosenBoss == ConsoleKey.D4){
                _playStyle = _Radium[1][0];
                _name = "   Radium   ";
                return _Radium[0];
            }
            else if (chosenBoss == ConsoleKey.D5){
                _playStyle = _CheaterFace[1][0];
                _name = "Cheater Face";
                return _CheaterFace[0];
            }
            else {
                Console.WriteLine("Incorrect input please try another");
            }
        }
    }

    public string PlayStyle(){
        return _playStyle;
    }

    public string ReturnName(){
        return _name;
    }
}