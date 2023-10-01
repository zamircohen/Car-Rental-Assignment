namespace Car_Rental.Classes
{
    public class Customer : Common.Interfaces.ICustomer
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int SSN { get; set; }
    }
}
