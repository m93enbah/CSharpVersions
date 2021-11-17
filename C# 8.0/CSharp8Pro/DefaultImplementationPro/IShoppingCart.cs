using System;

namespace DefaultImplementationPro
{
    //with the default implementation of interface , you dont need to implement all the method in the interface , only the needed one
    public interface IShoppingCart
    {
        public string fullName { get; set; }

        private static string defaultName = "Default ";

        //Default implementation method static can only access from another class
        public static void setDefaultName(string name)
        {
            defaultName = name;
        }

        //default impelementation method ordinal
        void CalcoulateSubTotal()
        {
            Console.WriteLine($"This is the {defaultName} Calcoulate Sub Total");
        }

        void CalcoulateTotal();
    }
}
