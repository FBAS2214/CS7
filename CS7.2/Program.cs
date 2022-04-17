using System;

namespace CS_7._1
{
    #region Sealed method

    class Base
    {
        public virtual void DoSomething() { }
    }

    class Derived1 : Base
    {
        // public new void DoSomething() { }
        // public override sealed void DoSomething() { }

    }

    class Derived2 : Base
    {
        public override void DoSomething() { }
    }

    #endregion


    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => $"{X} : {Y}";

        public override bool Equals(object obj)
        {
            if (obj is Point p)
            {
                if (p.X == X && p.Y == Y)
                    return true;
            }

            return false;
        }

        public override int GetHashCode() => X ^ Y;



        public static void Display(int num, string str)
            => Console.WriteLine($"Number: = {num} --- String = {str}");


    }


    class Program
    {
        static void Main(string[] args)
        {
            {
                // Point point1 = new Point { X = 10, Y = 20 };
                // Point point2 = new Point { X = 10, Y = 20 };
                // 
                // Console.WriteLine(point1.GetType());
                // Console.WriteLine(point1.Equals(point2));
                // Console.WriteLine(point1);
            }


            {
                // int n1 = 100;
                // int n2 = 42;

                // Console.WriteLine(n1.GetHashCode());
                // Console.WriteLine(n2.GetHashCode());
            }


            {
                // string s1 = "Salam";
                // string s2 = "Salam";
                // 
                // Console.WriteLine(s1.GetHashCode());
                // Console.WriteLine(s2.GetHashCode());
            }




            {
                // Point p1 = new Point { X = 10, Y = 20 };
                // Point p2 = new Point { X = 10, Y = 20 };
                // Point p3 = p2;
                // 
                // Console.WriteLine(p1.GetHashCode());
                // Console.WriteLine(p2.GetHashCode());
                // Console.WriteLine(p3.GetHashCode());
            }



            {
                Point.Display(5, "Hello");
                Point.Display(str: "Hello", num: 5);
            }

        }
    }
}
