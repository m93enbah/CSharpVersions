//in C# 10 there is lamda Expr which allow to make functiona and assign to variable as below
using System;

var fun01 = string() => "Hello World";
var fun02 = string (string fname, string lname) => $"{fname} {lname}";


Console.WriteLine(fun01());
Console.WriteLine(fun02("ali","ahmad"));

//you cannot assign null to lamda 
//var x = () => null;

//the solution of null as below by set return of the method
var txt = string? () => null;