using System;
using System.Collections.Generic;

namespace NullCoalescingAssignmentPro
{
    public class NullCoalescingAssignments
    {
        public static void Demo()
        {
            var example = new ListDemo();
            //we have null check that we check if example is null ignore the rest 
            example?.LuckyNumbers?.Add(15);
            //we use the null colescing by check if example.LuckyNumber is null create new list<int>
            example.LuckyNumbers ??= new List<int>();
            example.LuckyNumbers.Add(15);
            foreach (var item in example.LuckyNumbers)
            {
                Console.WriteLine($"Luck Number : {item}");
            }
        }
    }
}
