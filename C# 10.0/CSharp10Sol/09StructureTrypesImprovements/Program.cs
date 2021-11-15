namespace CSharp10Sol.StructureTypesImprovements
{
    public class MainEntry
    {
        public static void Main(string[] args)
        {
            //in C# 9 you have to use shallow copy
            var m1 = new Rectangle(10, 20);

            //in C# 10 you can create new instance with change prop in shorter way (Shallow Copy)
            var m2 = m1 with { Width = 30 };
            Console.WriteLine(m2);
        }
    }

    public struct Rectangle
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; init; }
        public int Width { get; init; }
    }
}


