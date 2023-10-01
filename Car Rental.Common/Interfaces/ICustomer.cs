namespace Car_Rental.Common.Interfaces
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int SSN { get; set; }
    }
}
