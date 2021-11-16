//in C# 10 if you want to prevent override method from access from child class / record 
//we can use sealed override as below 
//you see that you cannot inherit from parent becouse its sealed override method
public record Rectangle(int height, int width)
{
    public sealed override string ToString()
    {
        return $"Height is : {height} and width is {width}";
    }
}

public record Square : Rectangle
{
    public Square(int sideLenght) : base(sideLenght, sideLenght) { }

    //public override string ToString()
    //{
    //    return $"Side Length : {height}";
    //}
}
//=========================================//
//you see that you cannot inherit from parent becouse its sealed override method
public class Rectangle1
{
    public Rectangle1(int height, int width) 
    {
        this.height = height;
        this.width = width; 
    }
    public int height { get; set; }
    public int width { get; set; }

    //sealed override is now applied on method 
    public sealed override string ToString()
    {
        return $"Height is : {height} and width is {width}";
    }
}

public class Square1 : Rectangle1
{
    public Square1(int sideLenght) : base(sideLenght, sideLenght) { }

    //public override string ToString()
    //{
    //    return $"Side Length : {height}";
    //}
}

public class MainEntry1
{
    public static void Main(string[] args)
    {
        var sqr = new Square(100);
        sqr.ToString();
    }
}