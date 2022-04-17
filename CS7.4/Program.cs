using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CS_7._3
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => $"{X} : {Y}";


        public static Point operator +(Point p1, Point p2)
            => new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };

        public static Point operator -(Point p1, Point p2)
            => new Point { X = p1.X - p2.X, Y = p1.Y - p2.Y };

        public static Point operator -(Point p)
        {
            p.X = -p.X;
            p.Y = -p.Y;
            return p;
        }

        public static Point operator +(Point p)
        {
            if (p.X < 0) p.X *= -1;
            if (p.Y < 0) p.Y *= -1;
            return p;
        }


        public static Point operator ++(Point point)
         => new Point { X = point.X + 1, Y = point.Y + 1 };

        public static Point operator --(Point point)
            => new Point { X = point.X - 1, Y = point.Y - 1 };


        public static bool operator ==(Point p1, Point p2)
         => p1.X == p2.X && p1.Y == p2.Y;


        public static bool operator !=(Point p1, Point p2)
        => !(p1 == p2);

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = new Point { X = -15, Y = 25 };

            // Console.WriteLine(p1 == p2);
            // Console.WriteLine(p1 != p2);

            // Console.WriteLine(p1.GetHashCode());
            // Console.WriteLine(--p1);
            // Console.WriteLine(p1.GetHashCode());
            // Console.WriteLine(p1);

            Console.WriteLine(+p2);


            var JsonStr = JsonSerializer.Serialize(p1);
            File.WriteAllText("file.txt", JsonStr);
            var readJsonStr = File.ReadAllText("file.txt");
            Point result = JsonSerializer.Deserialize<Point>(readJsonStr);
            Console.WriteLine(result);
        }
    }
}
