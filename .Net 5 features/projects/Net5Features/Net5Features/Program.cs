using Net5Features;
using System;
Console.WriteLine(AddNumbers(5, 6));


var person = new PersonModel() {Id = 1, Fname = "ali", Lname = "ahmad" };


PersonModel person1 = new () { Id = 1, Fname = "ali", Lname = "ahmad" };

if (person1 is not null) 
{
    Console.WriteLine($"{person1.Fname} {person1.Lname} ({person1.Id})");
}
PersonModel person2 = new(2, "Isam", "Ali");

person.Fname ??= "asdasdas";

Console.WriteLine($"{person.Fname} {person.Lname} ({person.Id})");

Console.ReadLine();

static int AddNumbers(int a, int b)
{
    return a + b;
}


