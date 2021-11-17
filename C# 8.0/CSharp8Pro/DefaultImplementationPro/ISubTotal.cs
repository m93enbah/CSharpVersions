using System;

namespace DefaultImplementationPro
{
    //we can implement multiple interfaces with defautl implementation with the same method name as below
    public interface ISubTotal
    {
        void CalcoulateSubTotal()
        {
            Console.WriteLine($"This is the Sub Total Calcoulate Sub Total");
        }
    }
}
