using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Pro
{
    //with the default implementation of interface , you dont need to implement all the method in the interface , only the needed one
    public interface IShoppingCart
    {
        public string fullName { get; set; }

        private static string defaultName = "Default ";
        public static void setDefaultName(string name) 
        {
            defaultName = name;
        }
        void CalcoulateSubTotal() 
        {
            Console.WriteLine($"This is the {defaultName} Calcoulate Sub Total");
        }

        void CalcoulateTotal();
    }

    //we can implement multiple interfaces with defautl implementation with the same method name as below
    public interface ISubTotal 
    {
        void CalcoulateSubTotal()
        {
            Console.WriteLine($"This is the Sub Total Calcoulate Sub Total");
        }
    }

    //shoopingCart only see the CalcoulateTotal method
    class ShoppingCart : IShoppingCart
    {
        public string fullName { get; set; }

        public void CalcoulateTotal()
        {
            Console.WriteLine("This is the default Calcoulate Total for Shooping Cart");
        }
    }

    //BetterShoppingCart see the CalcoulateSubTotal and CalcoulateTotal methods

    public class BetterShoppingCart : IShoppingCart , ISubTotal
    {
        public string fullName { get; set; }

        public BetterShoppingCart(string name)
        {
            IShoppingCart.setDefaultName(name);
        }
        public void CalcoulateTotal()
        {
            Console.WriteLine("This is the default Calcoulate Total for Better Shopping Cart");
        }
    }
}
