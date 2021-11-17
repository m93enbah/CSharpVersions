using System;

namespace DefaultImplementationPro
{
    //shoopingCart only see the CalcoulateTotal method
    class ShoppingCart : IShoppingCart
    {
        public string fullName { get; set; }

        public void CalcoulateTotal()
        {
            Console.WriteLine("This is the default Calcoulate Total for Shooping Cart");
        }
    }
}
