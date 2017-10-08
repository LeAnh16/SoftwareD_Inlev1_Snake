using System;
using static System.Console;

namespace ClassLibrary
{
    public class ConsoleSetup
    {
		private string gameTitle = "Westerdals Oslo ACT - SNAKE";
		private int curserPosition = 10;
		private string snakeShape = "@";

		public ConsoleSetup()
		{
			CursorVisible = false;
			Title = gameTitle;
			ForegroundColor = ConsoleColor.Green;
			SetCursorPosition(curserPosition, curserPosition);
			Write(snakeShape);
		}

        public static void ChangeConsoleColor(ConsoleColor color){
            Console.ForegroundColor = color;
		}

        public static void CursorPosition(Point p, string str){
            Console.SetCursorPosition(p.Xaxel, p.Yaxel); Console.Write(str);
        }
    }
}
