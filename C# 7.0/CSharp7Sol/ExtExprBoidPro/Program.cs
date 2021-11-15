using System;
using System.Collections.Concurrent;

namespace ExtExprBoidPro
{
    //we see that we now can assign extended expression on constructor and destructor and fields as below
    class Person
    {
        private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();

        private int id = GetId();

        public Person(string name) => names.TryAdd(id, name); // constructors

        ~Person() => names.TryRemove(id, out _);              // finalizers

        public string Name
        {
            get => names[id];                                 // getters
            set => names[id] = value;                         // setters
        }

        public static int GetId() 
        {
            return 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Person("Mohammed Ali");
            emp = null;

            Console.ReadLine();
        }
    }
}
