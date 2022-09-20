using System;

namespace OOP
{
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int num)
        {
            Random rnd = new Random();
            this.x = rnd.Next(-num, num + 1);
            this.y = rnd.Next(-num, num + 1);
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}