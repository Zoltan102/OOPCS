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
        
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void DistanceToOrigo()
        {
            
        }

        public override string ToString()
        {
            return "[" + x + ";" + y + "]";
        }

        public void Deconstruct(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }
    }
}