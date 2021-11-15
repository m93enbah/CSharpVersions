using System;
using System.Linq;

namespace OutVarPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CallFunc1("1");

            // I only care about x
            //p.GetCoordinates(out var x, out _); 
            CallFunc2();

            //Note that out var declarations are of limited use in LINQ queries as expressions are interpreted as expression lambda bodies,
            //so the scope of the introduced variables is limited to these lambdas. For example, the following code will not work:
            //var nums =
            //    from item in seq
            //    let success = int.TryParse(item, out var tmp)
            //    select success ? tmp : 0; // Error: The name 'tmp' does not exist in the current context
            Console.ReadLine();
        }

        static void CallFunc1(string no)
        {
            //internally it will created at the top level of the function so it will accessiable at all rest code on the level of method
            if (int.TryParse(no, out int val))
            {
                Foo(ref val); // ok
            }
            else
            {
                Foo(ref val); // value is zero
            }
            //we can call it outside the scope and inside the scope
            Foo(ref val); 

            static void Foo(ref int val)
            {
                val = val + 1;
            }
        }

        //out params can be used with anonmous types
        static void CallFunc2() 
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var groupedByMod2 = a.Select(x => new
            {
                Source = x,
                Mod2 = x % 2
            }).GroupBy(x => x.Mod2)
              .ToDictionary(g => g.Key, g => g.ToArray());
            
            if (groupedByMod2.TryGetValue(1, out var oddElements))
            {
                Console.WriteLine(oddElements.Length);
            }
        }
    }
}
