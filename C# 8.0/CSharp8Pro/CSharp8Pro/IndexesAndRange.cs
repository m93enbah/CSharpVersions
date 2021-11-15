using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Pro
{
    public static class IndexesAndRange
    {
        public static void Demo() 
        {

            var places = new string[] { "First", "Second", "Third", "Fourth", "Fifth" };

            Console.WriteLine(places[^1]);  // it will return the last item of the array
            Console.WriteLine(places[^2]); // it will return the Fourth item

            //it will iterate from item index 1 to index n-2  (from second to fourth)
            foreach (var item in places[1..^1]) 
            {
                Console.Write($"{item} , ");
            }
            Console.WriteLine();

            //it will iterate from item index 0 to index n-2 (from first to fourth)
            foreach (var item in places[..^1]) 
            {
                Console.Write($"{item} , ");
            }
            Console.WriteLine();

            //it will iterate from index 1 to index n-1  (from second to fifth)
            foreach (var item in places[..]) 
            {
                Console.Write($"{item} , ");
            }
            Console.WriteLine();
        }
    }
}
