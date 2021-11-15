using System;

namespace BinaryLiteralsPro
{
    //With binary literals it is more obvious which bits are set, and using them does not require understanding hexadecimal numbers and bitwise arithmetic:
    [Flags]
    public enum DaysOfWeek
    {
        Monday = 0b00000001,
        Tuesday = 0b00000010,
        Wednesday = 0b00000100,
        Thursday = 0b00001000,
        Friday = 0b00010000,
        Saturday = 0b00100000,
        Sunday = 0b01000000,

        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday,
        Weekends = Saturday | Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using a binary literal:
            //   bits: 76543210
            int a1 = 0b00100010;          // binary: explicitly specify bits

            // Existing methods:
            int a2 = 0x22;                // hexadecimal: every digit corresponds to 4 bits
            int a3 = 34;                  // decimal: hard to visualise which bits are set
            int a4 = (1 << 5) | (1 << 1); // bitwise arithmetic: combining non-zero bits

            Console.ReadLine();
        }
    }
}
