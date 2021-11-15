using System;

namespace PatternMatchingPro
{
    class Geometry
    {
    }
    class Rectangle : Geometry
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    class Square : Geometry
    {
        public int Width { get; set; }
    }

    class Triangle : Geometry
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Base { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PatternMatching();
            var o = "hello";

            string s = o as string;
            if (s != null)
            {
                // do something with s
            }

            //it will check for variable o is null or not and create new instance at the same time
            if (o is string s1)
            {
                //Do something with s
            };
            Console.ReadLine();
        }
        public static void PatternMatching()
        {
            Geometry g = new Square { Width = 5 };
            switch (g)
            {
                case Triangle t:
                    Console.WriteLine($"{t.Width} {t.Height} {t.Base}");
                    break;
                case Rectangle sq when sq.Width == sq.Height:
                    Console.WriteLine($"Square rectangle: {sq.Width} {sq.Height}");
                    break;
                case Rectangle r:
                    Console.WriteLine($"{r.Width} {r.Height}");
                    break;
                case Square s:
                    Console.WriteLine($"{s.Width}");
                    break;
                default:
                    Console.WriteLine("<other>");
                    break;
            }
        }
    }
}
