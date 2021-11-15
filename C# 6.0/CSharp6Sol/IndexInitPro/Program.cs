using System;
using System.Collections.Generic;

namespace IndexInitPro
{
    public class MyClassWithIndexer
    {
        public int this[string index]
        {
            set
            {
                Console.WriteLine($"Index: {index}, value: {value}");
            }
        }
        public string this[int index]
        {
            set
            {
                Console.WriteLine($"Index: {index}, value: {value}");
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //old way in C# 5
            var dict2 = new Dictionary<int, string>()
            {
                {1,"Item01" },
                {2,"Item02" },
                {3,"Item03" },
                {4,"Item04" }
            };

            //new way in C# 6
            var dict = new Dictionary<string, int>()
            {
                ["foo"] = 34,
                ["bar"] = 42
            };

            //indexer initalizer with set key string 
            //it will initialize indexer with difffernt key types
            var x = new MyClassWithIndexer()
            {
                ["foo"] = 34,
                ["bar"] = 42,
                [10] = "Ten",
                [42] = "Meaning of life"
            };
            Console.WriteLine("Hello World!");
        }
    }
}
