using static System.Console;

namespace CSharp9Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            var person = new Person() { FullName = "Mohammed Nabil Enbeh" };
            WriteLine(person.FullName);
        }
    }


    public class Person 
    {
        public string FullName { get; set; }
    }
}
