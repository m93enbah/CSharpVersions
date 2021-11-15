using System;
using System.Data.SqlClient;

namespace ExceptionFilterPro
{
    class Program
    {
        static void Main(string[] args)
        {
           // Check01();
           // Check03();
           // Check04();
            Check05();
        }

        static void Check01() 
        {
            var SqlErrorToIgnore = 123;
            try
            {
               // DoSQLOperations();
            }
            //it will make filter to the exception check so not enter until the condition return true
            catch (SqlException ex) when (ex.Number != SqlErrorToIgnore)
            {
                throw new Exception("An error occurred accessing the database", ex);
            }
        }

        static void Check02() 
        {
            //try
            //{ ... }
            //catch (Exception ex) when (someCondition) //If someCondition evaluates to true , the rest of the catches are ignored.
            //{ ... }
            //catch (NotImplementedException ex) when (someMethod()) //someMethod() will only run if someCondition evaluates to false
            //{ ... }
            //catch (Exception ex) // If both when clauses evaluate to false
            //{ ... }
        }

        static void Check03()
        {
            int a = 7;
            int b = 0;
            try
            {
                DoSomethingThatMightFail();
            }
            catch (Exception ex) when (a / b == 0)
            {
                // This block is never reached because a / b throws an ignored
                // DivideByZeroException which is treated as false.
            }
            catch (Exception ex)
            {
                // This block is reached since the DivideByZeroException in the 
                // previous when clause is ignored.
            }
        }
        static void DoSomethingThatMightFail()
        {
            // This will always throw an ArgumentNullException.
            Type.GetType(null);
        }

        static void Check04() 
        {
            int a = 0, b = 0;
            //it will make exception on the same line not entered to the catch section
            try
            {
                int c = a / b;
            }
            catch (DivideByZeroException) when (a != 0)
            {
                throw;
            }
        }

        static void Check05() 
        {
            try
            {
               // DoSomethingThatMightFail(s);
            }
            catch (Exception ex)
            {
                Log(ex, "An error occurred");
                throw;
            }

            // ...

            static void Log(Exception ex, string message, params object[] args)
            {
               // Debug.Print(message, args);
            }
        }

        static void Check06() 
        {
            Console.WriteLine("Start");
            try
            {
                SomeOperation();
            }
            catch (Exception) when (EvaluatesTo())
            {
                Console.WriteLine("Catch");
            }
            finally
            {
                Console.WriteLine("Outer Finally");
            }
        }

        private static bool EvaluatesTo()
        {
           // Console.WriteLine($"EvaluatesTo: {Flag}");
            return true;
        }

        private static void SomeOperation()
        {
            try
            {
                //Flag = true;
                throw new Exception("Boom");
            }
            finally
            {
                //Flag = false;
                Console.WriteLine("Inner Finally");
            }
        }
    }
}
