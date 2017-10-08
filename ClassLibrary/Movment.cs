using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace ClassLibrary
{
    public class Movment
    {
        bool goodGame;
        bool pause;
        bool inUse;
        short newDirection; // 0 = up, 1 = right, 2 = down, 3 = left
        short lastDirection = 0;
        ClassLibrary.Board board;
        ClassLibrary.Point point;

		

        public Movment()
        {
            goodGame = false;
            pause = false;
            inUse = false;
            newDirection = 2;
            board = new Board();
            point = new Point();
        }

       /* public void GetPlayerInput(ConsoleKeyInfo keyInfo)
        {
            //lastDirection = newDirection;
            point.LastPosition = newDirection;

            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                    goodGame = true;
                else if (keyInfo.Key == ConsoleKey.Spacebar)
                    pause = !pause;
                else if (keyInfo.Key == ConsoleKey.UpArrow && lastDirection != 2)
                    newDirection = 0;
                else if (keyInfo.Key == ConsoleKey.RightArrow && lastDirection != 3)
                    newDirection = 1;
                else if (keyInfo.Key == ConsoleKey.DownArrow && lastDirection != 0)
                    newDirection = 2;
                else if (keyInfo.Key == ConsoleKey.LeftArrow && lastDirection != 1)
                    newDirection = 3;
            }
        }*/


        // gör alla metoder där och sen i gamecontroller chekc med en switch coch kalla på deom



       
    }
}

