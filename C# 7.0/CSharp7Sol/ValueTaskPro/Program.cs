using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ValueTaskPro
{
    //
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stopwatch sc1 = new Stopwatch();
            sc1.Start();

            IFoo<int> thing = new SynchronousFoo<int>();
            var x = thing.BarAsync();
            sc1.Stop();
            Console.WriteLine("Time For sync operation is " + sc1.ElapsedMilliseconds.ToString());

            sc1.Reset();
            sc1.Start();
            IFoo<int> thing2 = new AsynchronousFoo<int>();
            var x2 = thing.BarAsync();
            sc1.Stop();
            Console.WriteLine("Time For async operation is " + sc1.ElapsedMilliseconds.ToString());


            sc1.Reset();
            sc1.Start();
            TestTask(3).GetAwaiter().GetResult();
            sc1.Stop();
            Console.WriteLine("Time For TestTask operation is " + sc1.ElapsedMilliseconds.ToString());

            sc1.Reset();
            sc1.Start();
            TestValueTask(3).GetAwaiter().GetResult();
            sc1.Stop();
            Console.WriteLine("Time For TestValueTask operation is " + sc1.ElapsedMilliseconds.ToString());


            Console.ReadLine();

        }
        
        //used for async operation like read from database , etc.. , 77 ns
        static async Task<int> TestTask(int d) 
        {
            await Task.Delay(d);
            return 10;
        }

        //in case that the operation in sync it will make result 14 ns 
        static async ValueTask<int> TestValueTask(int d)
        {
            await Task.Delay(d);
            return 10;
        }

    }
}
