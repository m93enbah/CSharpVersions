//in C# 10 if you want to prevent override method from access from child class / record 
//we can use sealed override as below 

//you see that you cannot inherit from parent becouse its sealed override method
internal record Rectangle(int height, int width)
{
    public sealed override string ToString()
    {
        return $"Height is : {height} and width is {width}";
    }
}

internal record Square : Rectangle
{
    protected Square(int sideLenght) : base(sideLenght, sideLenght) { }

    //public override string ToString()
    //{
    //    return $"Side Length : {height}";
    //}
}
//=========================================//


//you see that you cannot inherit from parent becouse its sealed override method
internal class Rectangle1
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

internal class Square1 : Rectangle1
{
    protected Square1(int sideLenght) : base(sideLenght, sideLenght) { }

    //public override string ToString()
    //{
    //    return $"Side Length : {height}";
    //}
}

public class Main
{
    public static void main(string[] args)
    {
      

    }
}