using System;

namespace ImpOverResPro
{
    class Program
    {
        public static void Main()
        {
            Overloaded(DoSomething);
            Foo(() => () => 7);
            Foo(() => () => 7l);

        }

        static void Overloaded(Action action)
        {
            Console.WriteLine("overload with action called");
        }

        static void Overloaded(Func<int> function)
        {
            Console.WriteLine("overload with Func<int> called");
        }

        static int DoSomething()
        {
            Console.WriteLine(0);
            return 0;
        }


        static void Foo(Func<Func<long>> func) { }
        static void Foo(Func<Func<int>> func) { }
    }
}
