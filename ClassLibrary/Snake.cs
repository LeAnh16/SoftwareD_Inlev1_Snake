using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;


namespace ClassLibrary
{
    public class Snake
    {
        public List<Point> SnakeBody;

		public Snake()
		{
			SnakeBody = new List<Point>();

			for (int i = 0; i < 4; i++)
			{
				SnakeBody.Add(new Point(10, 10));
				SnakeBody.Add(new Point(10, 10));
				SnakeBody.Add(new Point(10, 10));
				SnakeBody.Add(new Point(10, 10));
			}

		}

      /*  public void PaintSnake(Board board, Point point){
            Random r = new Random();
            point.Xaxel = r.Next(0, board.BoardWidth);
            point.Xaxel = r.Next(0, board.BoardHeight);
            bool spotPoint = true;

            foreach(Point p in SnakeBody){
                if(p.Xaxel == point.Xaxel && p.Yaxel == point.Yaxel){
                    spotPoint = false;
                    break;
                }
                if(spotPoint){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(point.Xaxel, point.Yaxel);
                    Console.Write("$");
                    break;
                }
            }
            
        }*/
    }
}
