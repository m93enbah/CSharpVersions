namespace DefaultImplementationPro
{
    //in C# 8.0 provides default impelmentation
    //which allow to create method with body and access it through initiate instnace of type of interface not the interface type
    class Program
    {
        static void Main(string[] args)
        {
            //Shopping Cart only see the method it implement
            var shoopingCart = new ShoppingCart();
            shoopingCart.CalcoulateTotal();

            IShoppingCart shoopingCart2 = new ShoppingCart();
            shoopingCart2.CalcoulateTotal();
            //its allow to access to all methods include default implementation of the interface IShoppingCart
            shoopingCart2.CalcoulateSubTotal();   

            IShoppingCart betterShoppingCart = new BetterShoppingCart("New One");
            betterShoppingCart.CalcoulateTotal();
            //its allow to access to all methods include default implementation of the interface IShoppingCart
            betterShoppingCart.CalcoulateSubTotal();


            ISubTotal subTotal = new BetterShoppingCart("New One");
            //its allow to access to all methods include default implementation of the interface ISubTotal
            subTotal.CalcoulateSubTotal();
        }
    }
}
