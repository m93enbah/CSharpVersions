//with file scoped namespace no namespaces allowed on the same file
namespace MultiNameSpacesPro.FileScopedNameSpaces;
internal class Person 
{
    public string Name { get; set; }
}

//In C# 10 its prevent multi namespace declerations
//namespace MultiNameSpacesPro.WritersNameSpaces;
//internal class Booking
//{
//    public string Name2 { get; set; }
//}