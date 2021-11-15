
public class MainEntry
{
    public static void Main(string[] args)
    {
        //in C# 9.0 in order to make deconstruct we made custom deconstruct method 
        var rect = new Rectangle(200, 100);
        (int h, int w) = rect;

        //in C# 10 we can make it more  simple as below
        int height = 0;
        int width = 0;
        (height, width) = rect;
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


    internal void Deconstruct(out int height, out int width) 
    {
        height = Height;
        width = Width;
    }
}
