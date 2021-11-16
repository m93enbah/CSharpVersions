//with top level program in C# 9.0 we can dont use Main(string[] args) and execute directly as below
//its just entry point for your application 

//you cannot have access modifier on the top level program like private , protected , etc...

//can only file that is top level code in one place only
using System;

Console.WriteLine("Hello World");
Console.WriteLine(Add(4,3));
Console.WriteLine(Sub(4, 3));

double Add(double x,double y) 
{
    return x + y;   
}

static double Sub(double x, double y)
{
    return x - y;
}