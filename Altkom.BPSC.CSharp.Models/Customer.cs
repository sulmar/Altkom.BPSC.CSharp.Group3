namespace Altkom.BPSC.CSharp.Models
{
    //class CustomerInfo
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}

    //class CustomerInfo2
    //{
    //    public string LastName { get; set; }
    //    public bool IsDeleted { get; set; }
    //}


    


    public class Customer : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer()
        {

        }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
