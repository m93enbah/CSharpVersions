//in C# 10 there is lamda Expr which allow to make functiona and assign to variable as below
using System;

var helloWorld = () => "Hello World";
Console.WriteLine(helloWorld());


//you cannot assign null to lamda 
//var x = () => null;

//the solution of null as below by set return of the method
var txt = string? () => null;