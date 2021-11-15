using System;

namespace OperatorNameOfPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello(null));
            Console.WriteLine(SayHello("Ahmad"));

            //we can access to the property name as below
            Console.WriteLine(Strings.Foo);
            Console.WriteLine(Strings.Bar);

            Console.ReadLine();
        }

        public static string SayHello(string greeted)
        {
            if (greeted == null)
                //it will return the name of the property or class ,etc...
                return nameof(greeted);

            return $"Hello ${greeted}";
        }

        public static class Strings
        {
            public const string Foo = nameof(Foo); // Rather than Foo = "Foo"
            public const string Bar = nameof(Bar); // Rather than Bar = "Bar"
        }
    }
}
