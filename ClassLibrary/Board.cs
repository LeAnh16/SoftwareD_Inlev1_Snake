using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using static System.Console;


namespace ClassLibrary
{
    public class Board
    {
        int boardWidth;
        int boardHeight;

        public Board()
        {
            boardWidth = WindowWidth;
            boardHeight = WindowHeight;
        }

        public int BoardWidth
        {
            get => boardWidth;
            set => boardWidth = value;
        }

        public int BoardHeight
        {
            get => boardHeight;
            set => boardHeight = value;
        }
    }
}
