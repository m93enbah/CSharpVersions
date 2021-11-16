using static System.Console;
namespace RecordTypePro
{
    record PersonRecord(string FullName, int Age);

    class Program
    {
        static void Main(string[] args)
        {
            var per = new PersonModel(1,"ali", "ahmad");
            //with init you cannot change the value after assigned on the constructor
            //per.Id = 10;

            //or by using Record to prevent the value change after initialized
            var perRecord = new PersonRecord("Isam Ahmad", 23);
            //perRecord.FullName = "asdf" 

            WriteLine("Hello World!");
        }
    }
}
