namespace _07RecordsPro;    
//in records in C# 9.0 by default its class type with init prop internally 
//but in C# 10 its splitted into class , struct with init prop 

//we see struct type its init , cannot be change after assign
internal struct Rectangle { 
    public int Height { get; init; }
    public int Width { get; init; }
}
//you can change the record type as struct
internal record struct Person(string FirstName);

internal class Rectangle2
{
    public int Height { get; init; }
    public int Width { get; init; }
}

//we also can declare Record with type class as reference type
internal record class Person2(string FirstName);