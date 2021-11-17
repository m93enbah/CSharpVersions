using System;

namespace SwitchStatementPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DoMath(10, 20, MathType.Add);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static double DoMath(double x, double y, MathType mathType)
        {
            //Swith Expression New Format
            var output = mathType switch
            {
                MathType.Add => x + y,
                MathType.Subtract => x - y,
                MathType.Divide => x / y,
                MathType.Multiply => x * y,
                _ => throw new Exception("Bad Operation")
            };
            return output;
        }
    }

    public enum MathType
    {
        Add,
        Subtract,
        Multiply,
        Divide,
    }
}



