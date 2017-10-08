using ClassLibrary;

namespace Snake
{
    public class GameObject
    {
        public ClassLibrary.Snake snake;
        public ClassLibrary.Food food;
		public bool goodGame;
		public bool pause;
		public bool inUse;
		public bool gameOver;

    			
		public GameObject(int boardWith, int boardHeiht)
		{
			snake = new ClassLibrary.Snake();
            food = new ClassLibrary.Food(boardWith, boardHeiht);
			goodGame = false;
			pause = false;
			inUse = false;
			gameOver = false;
		}



    }
}
