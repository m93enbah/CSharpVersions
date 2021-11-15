using System;

namespace ThrowExprPro
{
    //we can apply throw expression in easy way throw ? or ?? 
    class Person
    {
        public string Name { get; }

        public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

        public string GetFirstName()
        {
            var parts = Name.Split(' ');
            return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
        }

        public string GetLastName() => throw new NotImplementedException();
    }

    class Program
    {
        static void Main(string[] args)
        {
            //before C# 7.0 if you want ot check if null or not
            var spoons = "dinner,desert,soup".Split(',');
            var spoonsArray = spoons.Length > 0 ? spoons : null;
            if (spoonsArray == null)
            {
                throw new Exception("There are no spoons");
            }

            //with C# 7.0 the check makes easier as below
            var spoonsArray1 = spoons.Length > 0 ? spoons : throw new Exception("There are no spoons");
            Console.ReadLine();
        }
    }
}
