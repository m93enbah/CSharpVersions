//General Using Statement
//(with this we can add global using command on the class that we want to declare all the dlls
//we want and using on any class on the project)
var names = new[] { "Nick", "John", "Mike", "Peter" };

var serialized = JsonSerializer.Serialize(names);

Console.WriteLine(serialized);