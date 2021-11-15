using Newtonsoft.Json;
using System;

namespace RecordTypePro
{



    /// <summary>
    /// Benefits of Record Type:
    /// 1-Simple to use
    /// 2-Thread Safe (becouse if we have two thread working on the same class instance)
    /// 3-easy to pass (share)
    /// 
    /// 
    /// 
    /// When to use records
    /// 1-Capuring external data that doesnot change - weatherService,SWAPI,
    /// 2-API Calls , and ViewModels
    /// 3-Processing Data
    /// 4-read only data
    /// 
    /// 
    /// When not to use records
    /// 1-when you want to update value (entity framework)
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>


    
    class Program
    {
        static void Main(string[] args)
        {
            //the difference between record and struct 
            //struct is value type and cannot be inherited or initalize 

            //record can inherit from record and class inherit from class




            //Record is class with extra stuff

            RecordType rc1 = new("F1", "L1");
            RecordType rc2 = new("F1", "L1");
            RecordType rc3 = new("F3", "L3");
            //internally its serialzie the object itself
            Console.WriteLine(rc1);
            //the records is reference but acting as value type it check to the value not to the address
            Console.WriteLine($"Are Records Equal : {Equals(rc1, rc2)}");
            //it will check to the reference address not value
            Console.WriteLine($"Are Records Reference Equal : {ReferenceEquals(rc1, rc2)}");
            //it will check to the value becouse its record type
            Console.WriteLine($"Are Records Reference == : {rc1 == rc2}");
            Console.WriteLine($"Are Class Reference == : {rc1 != rc2}");


            //the method GetHashCode() its get the hash code that represent the object if changed it will change the hash code
            //so in record type if the values are the same in two record instances the hash code will be the same
            //while in the class it will be different becouse its act as reference type
            Console.WriteLine($"Hash Code == : {rc1.GetHashCode()}");
            Console.WriteLine($"Hash Code == : {rc2.GetHashCode()}");
            Console.WriteLine($"Hash Code == : {rc3.GetHashCode()}");


            //Deconstruct Record Type (it internally function that deconstruct the record type to the anonmous tuple )
            var (fn, ln) = rc1;
            Console.WriteLine($"The First Name is {fn} and Last Name is {ln}");


            //Clonening object
            //in record type we can clone the same object to another object but not refer to the same reference address
            var rc4 = rc1 with 
            {
                fname = "Testing Final"
            };
            //so it will make copy of the rc1 and refer to its own instance 
            Console.WriteLine(rc4);
            Console.WriteLine(rc1);


            //RecordType 
            RecordType2 rec2 = new("Ali", "Ahmad");
            Console.WriteLine(rec2);
            Console.WriteLine(rec2.sayHello());


            RecordType3 rec3 = new(1,"Ali","Ahmad");
            rec3.sayHello();


           Console.WriteLine("**************************************************************************");








            RecordClass rct1 = new ("FC1", "LC1");
            RecordClass rct2 = new ("FC1", "LC1");
            RecordClass rct3 = new ("FC3", "LC3");
            //in order to make the same result with record we have to override the ToString() with using SerializeObject
            Console.WriteLine(rct1);
            //becouse its point to different address the result is no
            Console.WriteLine($"Are Class Equal : {Equals(rct1, rct2)}");
            //it will check to the reference address not value
            Console.WriteLine($"Are Class Reference Equal : {ReferenceEquals(rct1, rct2)}");
            //it will check to the address becouse its class type
            Console.WriteLine($"Are Class Reference == : {rct1 == rct2}");
            Console.WriteLine($"Are Class Reference == : {rct1 != rct2}");
            //so in record type if the values are the same in two record instances the hash code will be the same
            //while in the class it will be different becouse its act as reference type
            Console.WriteLine($"Hash Code == : {rct1.GetHashCode()}");
            Console.WriteLine($"Hash Code == : {rct2.GetHashCode()}");
            Console.WriteLine($"Hash Code == : {rct3.GetHashCode()}");


            //In order to apply Deconstruct Record Type we have to make custom mehtod and send two variable as output parameters
            string firsName;
            string lastName;
            rct1.Deconstruct(out firsName, out lastName);
            Console.WriteLine($"The First Name is {firsName} and Last Name is {lastName}");

            Console.ReadLine();
        }
    }


   

    public record RecordType(string fname,string lname);

    public record RecordType2(string FirstName, string LastName) 
    {

        private string _firstName = FirstName;
        public string FirstName {
            get { return _firstName.Substring(0, 1); }
            init { } 
        }


        //the properities must be in public access modifier to accept ToString()
        //public string FirstName { get; init; } = FirstName;
        public string FullName { get { return $"Full Name : {FirstName} {LastName}"; } }

        public string sayHello() 
        {
            return $"Hello {FullName}";
        }
    }


    //Dont do this with the records
    //1- use set; instead of init
    //2- declare record without constructor paramters
    //3- using clone of record as replacement of mutability of class becouse it will take large size of memory

    public record InvalidRecord 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public record RecordType3(int id,string fname,string lname) : RecordType2(fname,lname);

    //equivalent to the RecordType
    public class RecordClass 
    {
        public string Fname { get; init; }
        public string Lname { get; init; }


        public RecordClass(string fname, string lname) 
        {
            this.Fname = fname;
            this.Lname = lname;
        }

        

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }


        public void Deconstruct(out string firstName, out string lastName) 
        {
            firstName = Fname;
            lastName = Lname;
        }
    }





}
