using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvTuplesPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-named Tuple properities , on the () its called ValueTuple which is value type
            var result = CallFunc1();
            Console.WriteLine($"{result.sum} : {result.count} , Type : {result.GetType()}");

            //2-Tuple Desconstruction
            var (s, c) = result;
            Console.WriteLine($"After Destruct : S = {s} , C = {c}");

            //3-Tuple Swapping 
            (s, c) = (c, s);
            Console.WriteLine($"After Swapping : S = {s} , C = {c}");


            //4-Class Deconstruct : we using the destructor 
            var person = new Person { FirstName = "John", LastName = "Smith" };
            //it will call the destructor as below
            var (localFirstName, localLastName) = person;
            Console.WriteLine($"After Deconstruct class : first name : {localFirstName} , last name :{localLastName}");

            //5-Tuple Initialization 
            var name = (first: "John", middle: "Q", last: "Smith");
            Console.WriteLine($"Full Name {name.first} {name.middle} {name.last}");

            //6-Tuple Initialization within method
            var lst = new List<int>() { 100, 110, 120 };
            var resMath = Measure(lst);
            Console.WriteLine($"Sum : {resMath.sum} , Avg : {resMath.average}");

            //7-working with Collection Tuples 
            var matchedRes = FindMatchingValue("test1","test2");
            Console.ReadLine();
        }

        //we can make function with return tuple with names each property as below
        public static (int sum, int count) CallFunc1()
        {
            return (1, 2);
        }

        //Tuple Initialization within method
        public static (int sum, double average) Measure(List<int> items)
        {
            var stats = (sum: 0, average: 0d);
            stats.sum = items.Sum();
            stats.average = items.Average();
            return stats;
        }


        //Tuple Initialization with async method with using ValueTyple Type
        //public async Task<(string value, int count)> GetValueAsync()
        //{
        //    string fooBar = await _stackoverflow.GetStringAsync();
        //    int num = await _stackoverflow.GetIntAsync();

        //    return (fooBar, num);
        //}

        //we can create Collection of tuple in the new format in C# 7.0
        private static readonly List<(string firstThingy, string secondThingyLabel, string foundValue)> labels = new List<(string firstThingy, string secondThingyLabel, string foundValue)>()
        {
            ("test1", "test2", "Value"),
            ("test1", "test1", "Value2"),
            ("test2", "test2", "Value3"),
        };

        public static string FindMatchingValue(string firstElement, string secondElement)
        {
            var result = labels?
                .Where(w => w.firstThingy == firstElement && w.secondThingyLabel == secondElement)
                .FirstOrDefault();

            if (result == null)
                throw new ArgumentException("combo not found");

            return result.Value.foundValue;
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
