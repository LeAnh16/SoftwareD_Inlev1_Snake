using System;
namespace ClassLibrary
{
    public class Point
    {
       	#region private fields
		private int _x;
		private int _y;
        private short lastPosition;
        #endregion



		public Point()
		{
		}

		public Point(int x = 0, int y = 0)
		{
			_x = x; _y = y;
		}
		public Point(Point input)
		{
			_x = input.Xaxel;
			_y = input.Yaxel;
		}


		public int Xaxel
		{
			get;
			set;
		}

		public int Yaxel
		{
			get;
			set;
		}

        public short LastPosition {
            get;
            set;
        }

    }
}
