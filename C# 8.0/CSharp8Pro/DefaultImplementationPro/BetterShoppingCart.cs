using System;

namespace DefaultImplementationPro
{
    //BetterShoppingCart see the CalcoulateSubTotal and CalcoulateTotal methods

    public class BetterShoppingCart : IShoppingCart, ISubTotal
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
