using System;

namespace DigitSepPro
{
    //Where the _ digit separator may not be used:
    //1-at the beginning of the value(_121)
    //2-at the end of the value(121_ or 121.05_)
    //3-next to the decimal (10_.0)
    //4-next to the exponent character(1.1e_1)
    //5-next to the type specifier(10_f)
    //6-immediately following the 0x or 0b in binary and hexadecimal literals(might be changed to allow e.g.
    class Program
    {
        //in order to make more readable value we using digit seperator as below
        static void Main(string[] args)
        {
            int bin = 0b1001_1010_0001_0100;
            int hex = 0x1b_a0_44_fe;
            int dec = 33_554_432;
            int weird = 1_2__3___4____5_____6______7_______8________9;
            double real = 1_000.111_1e-1_000;
            Console.ReadLine();
        }
    }
}
