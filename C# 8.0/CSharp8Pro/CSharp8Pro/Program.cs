using System;

namespace CSharp8Pro
{
    class Program
    {
        static void Main(string[] args)
        {


            //var rect = new Rectangle();
            //rect.height = 50;
            //rect.length = 100;
            //Console.WriteLine($"Before Area : {rect.Area()}");
            //rect.length = 200;
            //Console.WriteLine($"After Area : {rect.Area()}");


            //Shopping Cart only see the method it implement
            //var shoopingCart = new ShoppingCart();
            //shoopingCart.CalcoulateTotal();


            ////in order to access all methods we can make interface variable
            //IShoppingCart shoopingCart2 = new ShoppingCart();
            //shoopingCart2.CalcoulateTotal();
            //shoopingCart2.CalcoulateSubTotal();

            ////in order to access all methods we can make interface variable
            //IShoppingCart betterShoppingCart = new BetterShoppingCart("New One");
            //betterShoppingCart.CalcoulateTotal();
            //betterShoppingCart.CalcoulateSubTotal();

            ////we can impelment multiple interfaces with the default action name and access to the method we want by sepcify the interface name as below
            //ISubTotal subTotal = new BetterShoppingCart("New One");
            //subTotal.CalcoulateSubTotal();



            //with using decleration 
            UsingDecleration.ConvertFiles();


            //with using Indexes

            //IndexesAndRange.Demo();
            NullCoalescingAssignments.Demo();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }




}
