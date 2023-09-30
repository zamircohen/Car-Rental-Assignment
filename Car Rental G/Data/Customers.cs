using Car_Rental_G.Classes;

namespace Car_Rental_G.Data
{
    public static class CustomersDatabase
    {
        public static List<Customer> customers { get; } = new List<Customer>
        {
            new Customer { FirstName = "Michael", LastName = "Savage", SSN = 12345 },
            new Customer { FirstName = "Nicole", LastName = "Cohen", SSN = 46567 },
            new Customer { FirstName = "John", LastName = "Doe", SSN = 98765 }
        };
    }
}
