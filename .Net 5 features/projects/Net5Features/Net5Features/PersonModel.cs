using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5Features
{
    public class PersonModel
    {
        public int Id { get; init; }

        public string Fname { get; set; }

        public string Lname { get; set; }


        public PersonModel() 
        {

        }
        public PersonModel(int id, string fname, string lname) 
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
        }
    }
}
