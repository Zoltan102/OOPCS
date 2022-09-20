using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point[] points = new Point[100];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(10);
            }
            foreach (var p in points)
            {
                Console.WriteLine(p + " " + p.DistanceToOrigo);
            }

            int farthestIndex = 0;
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i].DistanceToOrigo > points[farthestIndex].DistanceToOrigo)
                {
                    farthestIndex = i;
                }
            }
            Console.WriteLine($"A(z) {(farthestIndex+1)}. pont {points[farthestIndex]} van a legtávolabb az otigótól." +
                              $" Távolság az origótól: {points[farthestIndex].DistanceToOrigo: 0.000}");
        }
    }
}