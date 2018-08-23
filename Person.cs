namespace ListReference 
{
    public class PersonReferenceType 
    {   public int Id { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonReferenceType(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;         
        }
    }
}