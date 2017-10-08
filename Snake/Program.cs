using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using ClassLibrary;
using static System.Console;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GameController gameController = new GameController();
           // while(true){
                gameController.LoopTheGame();
            //}
        }
    }
}
