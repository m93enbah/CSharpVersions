using System;

namespace StringInterPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CallFunc1());
            Console.WriteLine(CallFunc2());
            Console.WriteLine(CallFunc3());
            Console.WriteLine(CallFunc4());
            Console.WriteLine(CallFunc5());
            Console.WriteLine(CallFunc6());

            Console.ReadLine();
        }

        static string CallFunc1() 
        {
            int foo = 34;
            int bar = 42;
            return $"The foo is {foo}, and the bar is {bar}.";
        }

        static string CallFunc2() 
        {
            var foo = 34;
            var bar = 42;

            // String interpolation notation (new style)
           return  $"The foo is {{foo}}, and the bar is {{bar}}.";
        }

        //we can use string interpolation among multiple lines
        static string CallFunc3() 
        {
            var foo = 34;
            var bar = 42;

            return $@"In case it wasn't clear:
            \u00B9
            The foo
            is {foo},and the baris {bar}.";
        }

        //you can apply mathmatic operations with the string interpolation as below , and apply formatting to property as below
        static string CallFunc4() 
        {
            var foo = 34;
            var bar = 42;
            return @$"And the greater one is: { Math.Max(foo, bar) } 
                      Price: {foo:c4}
                      Today: {DateTime.Now:dddd,MMMM dd - yyyyy}";
        }

        //you can apply conditional statement inside string interpolation
        static string CallFunc5() 
        {
            var foo = 34;
            var bar = 42;
            return $"{(foo > bar ? "Foo is larger than bar" : "Bar is larger than Foo")}";
        }


        //the escape character such as \" working as expected as the normal state
        static string CallFunc6() 
        {
            var foo = 34;
            return $"Foo is: {foo}. In a non-verbatim string, we need to escape \" and \\ with backslashes.";
        }
    }
}
