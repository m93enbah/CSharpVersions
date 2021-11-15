using System;
using System.Collections.Generic;

namespace AutoPropInitPro
{
    public class Coordinate
    {
        // get or set auto-property with initializer
        public int X { get; set; } = 34;

        // read-only auto-property with initializer
        public int Y { get; } = 89;

        // Read-only auto-property with expression body , instead of using {get;} as readonly property
        public ICollection<string> Users3 => new HashSet<string>() { "OP1", "OP2" };

        //get or set auto-property with initializer with detect access modifier , internal , internal protected , private
        public string Name { get; protected set; } = "Cheeze";

        //we can set readonly list 
        public List<string> Ingredients { get; } = new List<string> { "dough", "sauce", "cheese" };


        //this way we using expression body on the get accessor to access to the private field as below
        private ICollection<string> _User4 = new HashSet<string>() { "OP1", "OP2" };
        public ICollection<string> Users4 { get => _User4; set { _User4 = value; } }
    }

    public class Rectangle
    {
        //to initialize auto properties as below
        public double Length { get; set; } = 1;
        //can set Width property at different level of layer , so cannot change outside
        public double Width { get; private set; } = 1;
        //we can use static method on set properities as below
        public double Area { get; set; } = CalculateArea(1, 1);

        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Coordinate cord = new Coordinate();
            //it will not add new items but readonly better way that the {get;} , its readonly property which is not added after initialized 
            cord.Users3.Add("asd");
            //becouse its read only you cannot assign
            //cord.Y = 11;

            //becouse its readonly list you cannot add new items
            //cord.Ingredients.Add("adsad");


            Rectangle rect = new Rectangle();
            //cannot set private set field as below
            //rect.Width = 2223;
            Console.WriteLine(rect.Area.ToString());
            Console.ReadLine();
        }
    }
}
