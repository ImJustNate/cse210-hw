using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Net.Http.Headers;
using System;

class Animation
{
    private List<string> _rockList = [
        " _______________________________________________ ",
        "|                                               |",
        "|                   ___   ____                  |" ,
        "|                /-   ----     \\_               |",
        "|              |                 |_             |" ,
        "|            |-                     \\           |",
        "|            /                        \\_        |",
        "|           /                           |       |" ,
        "|          /                            |       |" ,
        "|         |                              |      |" ,
        "|         |                              |      |" ,
        "|        /                               |      |" ,
        "|       /                                |      |" ,
        "|       \\                                |      |",
        "|        \\                             _/       |",
        "|         \\                        ___/         |",
        "|          \\______________________/             |",
        "|_______________________________________________|" 
        ];
        
    private List<string> _paperList = [
        " _______________________________________________ ",
        "|                                               |",
        "|           _______________                     |",
        "|          |               |\\_                  |",
        "|          |               |  \\_                |",
        "|          |               |    \\_              |",
        "|          |               |      \\_            |",
        "|          |               |________\\_          |",
        "|          |                         |          |",
        "|          |                         |          |",
        "|          |                         |          |",
        "|          |                         |          |",
        "|          |                         |          |",
        "|          |                         |          |",
        "|          |                         |          |",
        "|          |_________________________|          |",
        "|                                               |",
        "|_______________________________________________|"
        ];
    
    private List<string> _ScissorsList = [
        " _______________________________________________ ",
        "|                                               |",
        "|                 _______                       |",
        "|                |   ___  \\                     |",
        "|                |  |___|  |                    |",
        "|                 \\__      |                    |",
        "|         __________  --___/                    |",
        "|        |  ____  | \\      \\__                  |",
        "|        | |____| |  |       --___              |",
        "|        \\________|   \\  --__     --__          |",
        "|                      \\   \\   -_      \\        |",
        "|                       \\   \\    --__   \\       |",
        "|                        \\   \\       --__\\      |",
        "|                         \\   \\                 |",
        "|                          \\   \\                |",
        "|                           \\   \\               |",
        "|                             ---               |",
        "|_______________________________________________|"
    ];

    private List<string> _deadList =[
        " _______________________________________________ ",
        "|                                               |",
        "|             _                   _             |",
        "|           _( )                 ( )_           |",
        "|          (_, |      __ __      | ,_)          |",
        "|             \\'\\    /  ^  \\    /'/             |",
        "|              '\\'\\,/\\      \\,/'/'              |",
        "|                '\\| []   [] |/'                |",
        "|                  (_  /^\\  _)                  |",
        "|                    \\  ~  /                    |",
        "|                    /HHHHH\\                    |",
        "|                  /'/{^^^}\\'\\                  |",
        "|              _,/'/'  ^^^  '\\'\\,_              |",
        "|             (_, |           | ,_)             |",
        "|               (_)           (_)               |",
        "|                                               |",
        "|                                               |",
        "|_______________________________________________|"
    ];

    private List<string> _blankList =[
        " _______________________________________________ ",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|                                               |",
        "|_______________________________________________|"
    ];


    public void DisplayDeath(){
        Console.WriteLine();
        
        Console.WriteLine(" _______________________________________________ ");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|             _                   _             |");
        Console.WriteLine("|           _( )                 ( )_           |");
        Console.WriteLine("|          (_, |      __ __      | ,_)          |");
        Console.WriteLine("|             \\'\\    /  ^  \\    /'/             |");
        Console.WriteLine("|              '\\'\\,/\\      \\,/'/'              |");
        Console.WriteLine("|                '\\| []   [] |/'                |");
        Console.WriteLine("|                  (_  /^\\  _)                  |");
        Console.WriteLine("|                    \\  ~  /                    |");
        Console.WriteLine("|                    /HHHHH\\                    |");
        Console.WriteLine("|                  /'/{^^^}\\'\\                  |");
        Console.WriteLine("|              _,/'/'  ^^^  '\\'\\,_              |");
        Console.WriteLine("|             (_, |           | ,_)             |");
        Console.WriteLine("|               (_)           (_)               |");
        Console.WriteLine("|_______________________________________________|");
    }
    
    public List<string> ReturnDeath(){
        return _deadList;
    }

    public void DisplayHomePage(){
        Console.WriteLine("\t _____________________________________________________________________________");
        Console.WriteLine("\t|                                                                             |");
        Console.WriteLine("\t|                   This is my really cool home page                          |");
        Console.WriteLine("\t|_____________________________________________________________________________|");
    
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
    public void DisplayHowTo(){
        Console.WriteLine("\t _____________________________________________________________________________");
        Console.WriteLine("\t|                                                                             |");
        Console.WriteLine("\t|                   These are the rules:                                      |");
        Console.WriteLine("\t|                   Rock beats Scissors                                       |");
        Console.WriteLine("\t|                   Paper beats Rock                                          |");
        Console.WriteLine("\t|                   Scissors beats Paper                                      |");
        Console.WriteLine("\t|_____________________________________________________________________________|");
        
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
    }

    public void DisplayOptions(){
        for (int i = 0; i < 18 ; i++) {
            
            Console.WriteLine("{0,53}{1,53}{2,53}",
                _rockList[i],
                _paperList[i],
                _ScissorsList[i]
                );
            if (i == 0){
                Console.WriteLine("{0,53}{1,53}{2,53}",
                "|  Press 1 then ENTER to select Rock as a card  |",
                "|  Press 2 then ENTER to select paper as a card |",
                "|Press 3 then ENTER to select scissors as a card|"
                    );
                i++;
            }
        }
        
    }

    public void DisplayRock(){
        Console.WriteLine("\t ______________________________________________"  );
        Console.WriteLine("\t|                                               |");
        Console.WriteLine("\t|                   ___   ____                  |" );
        Console.WriteLine("\t|                /-   ----     \\_               |");
        Console.WriteLine("\t|              |                 |_             |" );
        Console.WriteLine("\t|            |-                     \\           |");
        Console.WriteLine("\t|            /                        \\_        |");
        Console.WriteLine("\t|           /                           |       |" );
        Console.WriteLine("\t|          /                            |       |" );
        Console.WriteLine("\t|         |                              |      |" );
        Console.WriteLine("\t|         |                              |      |" );
        Console.WriteLine("\t|        /                               |      |" );
        Console.WriteLine("\t|       /                                |      |" );
        Console.WriteLine("\t|       \\                                |      |");
        Console.WriteLine("\t|        \\                             _/       |");
        Console.WriteLine("\t|         \\                        ___/         |");
        Console.WriteLine("\t|          \\______________________/             |");
        Console.WriteLine("\t| ______________________________________________|" );
    }

    public List<string> ReturnRock(){
        return _rockList;
    }

    public void DisplayPaper(){
        Console.WriteLine("\t ______________________________________________");
        Console.WriteLine("\t|                                               |");
        Console.WriteLine("\t|           _______________                     |");
        Console.WriteLine("\t|          |               |\\_                  |");
        Console.WriteLine("\t|          |               |  \\_                |");
        Console.WriteLine("\t|          |               |    \\_              |");
        Console.WriteLine("\t|          |               |      \\_            |");
        Console.WriteLine("\t|          |               |________\\_          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |                         |          |");
        Console.WriteLine("\t|          |_________________________|          |");
        Console.WriteLine("\t|                                               |");
        Console.WriteLine("\t| ______________________________________________|");
    }
    
    public List<string> ReturnPaper(){
        return _paperList;
    }
    
    public void DisplayScissors(){
        Console.WriteLine("\t _______________________________________________");
        Console.WriteLine("\t|                                               |");
        Console.WriteLine("\t|                 _______                       |");
        Console.WriteLine("\t|                |   ___  \\                     |");
        Console.WriteLine("\t|                |  |___|  |                    |");
        Console.WriteLine("\t|                 \\__      |                    |");
        Console.WriteLine("\t|         __________  --___/                    |");
        Console.WriteLine("\t|        |  ____  | \\      \\__                  |");
        Console.WriteLine("\t|        | |____| |  |       --___              |");
        Console.WriteLine("\t|        \\________|   \\  --__     --__          |");
        Console.WriteLine("\t|                      \\   \\   -_      \\        |");
        Console.WriteLine("\t|                       \\   \\    --__   \\       |");
        Console.WriteLine("\t|                        \\   \\       --__\\      |");
        Console.WriteLine("\t|                         \\   \\                 |");
        Console.WriteLine("\t|                          \\   \\                |");
        Console.WriteLine("\t|                           \\   \\               |");
        Console.WriteLine("\t|                             ---               |");
        Console.WriteLine("\t|_______________________________________________|");
        
    }

    public List<string> ReturnScissors(){
        return _ScissorsList;
    }

    public List<string> ReturnBlank(){
        return _blankList;
    }

    public void DisplayBattleField(){
            Console.WriteLine ("     _______________________________________________      _______________________________________________      _______________________________________________ ");
            Console.WriteLine ("    |                                               |    |                                               |    |                                               |");
            Console.WriteLine ("    |                                               |    |                                               |    |                  _________                    |");
            Console.WriteLine ("    |                                               |    |                                               |    |                /          \\                   |");
            Console.WriteLine ("    |                                               |    |                                               |    |                |           |                  |");
            Console.WriteLine ("    |                                               |    |                                               |    |                |           |                  |");
            Console.WriteLine ("    |                                               |    |                                               |    |                            |                  |");
            Console.WriteLine ("    |                                               |    |                                               |    |                          __                   |");
            Console.WriteLine ("    |                                               |    |                       vs                      |    |                        __                     |");
            Console.WriteLine ("    |                                               |    |                                               |    |                      __                       |");
            Console.WriteLine ("    |                                               |    |                                               |    |                      |                        |");
            Console.WriteLine ("    |                                               |    |                                               |    |                      |                        |");
            Console.WriteLine ("    |                                               |    |                                               |    |                                               |");
            Console.WriteLine ("    |                                               |    |                                               |    |                     ___                       |");
            Console.WriteLine ("    |                                               |    |                                               |    |                    |___|                      |");
            Console.WriteLine ("    |                                               |    |                                               |    |                                               |");
            Console.WriteLine ("    |_______________________________________________|    |_______________________________________________|    |_______________________________________________|");
    }

    public void DisplayContinueHand(){
        
        Console.WriteLine("     _________________________________________________________________________________________________________________________________________________________");
        Console.WriteLine("    |                                                                                                                                                         |");
        Console.WriteLine("    |    Your hand is made up of the following cards. Press ENTER when you are ready to continue!                                                             |");
        Console.WriteLine("    |_________________________________________________________________________________________________________________________________________________________|");
        
    }
public void DisplayRoundCounter(int roundCounter){
            Console.WriteLine ("\t\t ______________________________________________________________________________________________________________________________");
            Console.WriteLine ("\t\t|                                                                                                                              |");
            Console.WriteLine ($"\t\t|                                R   O   U   N   D                 {roundCounter}                      F   I   G   H   T                    |");
            Console.WriteLine ("\t\t|______________________________________________________________________________________________________________________________|");
}
} 
