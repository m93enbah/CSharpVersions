using System;

namespace RefReturnAndRefLocalPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public  static ref TValue Choose<TValue>(Func<bool> condition, ref TValue left, ref TValue right)
        {
            return condition() ? ref left : ref right;
        }

        public static ref int Max(ref int first, ref int second, ref int third)
        {
            ref int max = first > second ? ref first : ref second;
            return max > third ? ref max : ref third;
        }
    }
}
