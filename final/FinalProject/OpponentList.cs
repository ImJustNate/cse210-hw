class OpponentList{
    public List<List<string>> _LucyKyn = 
        [["1", "2", "3"], ["Loose"]];
    public List<List<string>> _OrigamiMan = 
        [["2", "2", "2"], ["rand"]];
    public List<List<string>> _LandSlide = 
        [["1", "1", "3"], ["complexRock"]];
    public List<List<string>> _Radium = 
        [["random"], ["rand"]];
    public List<List<string>> _CheaterFace = 
        [["random"], ["win"]];
    private string _playStyle = "";

    public List<string> Menu(){
        while (true){
            Console.WriteLine(  "Which boss would you like to fight? \n"+
                                "Press 1 to select Lucy Kyn\n"          +
                                "Press 2 to select Origami Man\n"       +
                                "Press 3 to select The Land Slide\n"    +
                                "Press 4 to select Radium\n"            +
                                "Press 5 to select Cheater Face\n");
            string chosenBoss = Console.ReadLine();

            if (chosenBoss == "1"){
                _playStyle = _LucyKyn[1][0];
                return _LucyKyn[0];
            }
            else if (chosenBoss == "2"){
                _playStyle = _OrigamiMan[1][0];
                return _OrigamiMan[0];
            }
            else if (chosenBoss == "3"){
                _playStyle = _LandSlide[1][0];
                return _LandSlide[0];
            }
            else if (chosenBoss == "4"){
                _playStyle = _Radium[1][0];
                return _Radium[0];
            }
            else if (chosenBoss == "5"){
                _playStyle = _CheaterFace[1][0];
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
}