using System;


public delegate void cordinate(int x);

namespace ClassLibrary
{
    public class Food
    {
		private int _boardWith;
		private int _boardHeiht;

        private Point point;
        private Board board;
        Snake snake;

		public Food()
		{
		}

		public Food(int boardWith, int boardHeiht)
		{
            point = new Point();
            point.Xaxel = 
			_boardHeiht = boardHeiht;
			_boardWith = boardWith;
            snake = new Snake();
			
			point.Xaxel = new Random().Next(0, board.BoardWidth);
			point.Yaxel = new Random().Next(0, board.BoardHeight);
		}

        public void RandomPosition()
		{
            point.Xaxel = new Random().Next(0, board.BoardWidth); 
            point.Yaxel = new Random().Next(0, board.BoardHeight);

		}

        public void PositionFoodOnScene(){
            while(true){
                RandomPosition();
                bool freeSpot = true;
                foreach(Point p in snake.SnakeBody){
                    if(p.Xaxel == point.Xaxel && p.Yaxel == point.Yaxel){
                        freeSpot = false;
                        break;
                    }
                    if (freeSpot){
                        ConsoleSetup.ChangeConsoleColor(ConsoleColor.Green);
                        ConsoleSetup.CursorPosition(point, "$");
                        break;
                    }
                }
            }
        }
    }
}
