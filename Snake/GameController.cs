using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using ClassLibrary;

namespace Snake
{
    public class GameController
    {
        Board board;
        Point point = new Point();
        ClassLibrary.Snake snake;
        //ClassLibrary.Snake snake;
        Movment movment;
        bool goodGame = false;
		bool pause = false;
		bool inUse = false;
        short newDirection = 2; // 0 = up, 1 = right, 2 = down, 3 = left
                               //short lastPosition = 0;

        Point tail;// = new Point(ClassLibrary.Snake.SnakeBody.First());
        Point head;// = new Point(ClassLibrary.Snake.SnakeBody.Last());
        Point newHead;//= new Point(head);

		Stopwatch stopWatch = new Stopwatch();
        //ConsoleKeyInfo getKey;


        public GameController()
        {
            snake = new ClassLibrary.Snake();
            var consoleSetup = new ConsoleSetup();
            board = new Board();
            movment = new Movment();
            //getKey = new ConsoleKeyInfo();
            tail = new Point(snake.SnakeBody.First());
            head = new Point(snake.SnakeBody.Last());
        }

        public void LoopTheGame(){
            //getKey = Console.ReadKey(true);
            short lastDirection = newDirection;

            stopWatch.Start();
            while (!goodGame)
            {
				//lastDirection = newDirection;
				point.LastPosition = newDirection;

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
					//keyInfo = Console.ReadKey(true);
                    if (KeyInfo.Key == ConsoleKey.Escape)
						goodGame = true;
                    else if (KeyInfo.Key == ConsoleKey.Spacebar)
						pause = !pause;
                    else if (KeyInfo.Key == ConsoleKey.UpArrow && lastDirection != 2)
						newDirection = 0;
                    else if (KeyInfo.Key == ConsoleKey.RightArrow && lastDirection != 3)
						newDirection = 1;
                    else if (KeyInfo.Key == ConsoleKey.DownArrow && lastDirection != 0)
						newDirection = 2;
                    else if (KeyInfo.Key == ConsoleKey.LeftArrow && lastDirection != 1)
						newDirection = 3;
				}

                if (!pause)
				{
				
    				if (stopWatch.ElapsedMilliseconds < 100)
    				{
                            continue;
    				}
                    else{
                        stopWatch.Restart();
                    }

               // tail = new Point(ClassLibrary.Snake.SnakeBody.First());
               // head = new Point(ClassLibrary.Snake.SnakeBody.Last());
				newHead = new Point(head);

				switch (newDirection)
				{
					case 0:
						newHead.Yaxel -= 1;
						break;
					case 1:
						newHead.Xaxel += 1;
						break;
					case 2:
						newHead.Yaxel += 1;
						break;
					default:
						newHead.Xaxel -= 1;
						break;
				}

				if (newHead.Xaxel < 0 || newHead.Xaxel >= board.BoardWidth)
					goodGame = true;
				else if (newHead.Yaxel < 0 || newHead.Yaxel >= board.BoardHeight)
					goodGame = true;

                    if (newHead.Xaxel == point.Xaxel && newHead.Yaxel == point.Yaxel)
                    {
                        if (snake.SnakeBody.Count + 1 >= board.BoardWidth * board.BoardHeight)
                            // No more room to place apples - game over.
                            goodGame = true;
                        else
                        {
                            while (true)
                            {
                                point.Xaxel = new Random().Next(0, board.BoardWidth);
                                point.Yaxel = new Random().Next(0, board.BoardHeight);
                                bool found = true;
                                foreach (Point p in snake.SnakeBody)
                                    if (p.Xaxel == point.Xaxel && p.Yaxel == point.Yaxel)
                                    {
                                        found = false;
                                        break;
                                    }
                                if (found)
                                {
                                    inUse = true;
                                    break;
                                }
                            }
                        }
                    }

				}
				if (!inUse)
				{
                    snake.SnakeBody.RemoveAt(0);
                    foreach (Point p in snake.SnakeBody)
                        if (p.Xaxel == newHead.Xaxel && p.Yaxel == newHead.Yaxel)
						{
							// Death by accidental self-cannibalism.
                            goodGame = true;
							break;
						}
				}
                if (!goodGame)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(head.Xaxel, head.Yaxel); Console.Write("0");
					if (!inUse)
					{
                        Console.SetCursorPosition(tail.Xaxel, tail.Yaxel); Console.Write(" ");
					}
					else
					{
                        Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(point.Xaxel, point.Yaxel); Console.Write("$");
						inUse = false;
					}
                    snake.SnakeBody.Add(newHead);
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.SetCursorPosition(newHead.Xaxel, newHead.Yaxel); Console.Write("@");
                    point.LastPosition = newDirection;
                    //last = newDir;
				}

            }
       }
    }
}
