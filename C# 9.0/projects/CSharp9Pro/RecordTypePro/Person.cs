namespace RecordTypePro
{
    public class PersonModel
    {
        public PersonModel(int id,string fname,string lname) 
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
        }

        public int Id { get; init; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
