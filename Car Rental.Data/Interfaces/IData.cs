using System.Collections.Generic;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces
{
    public interface IData
    {
        IEnumerable<ICustomer> GetCustomers();
        IEnumerable<IVehicle> GetVehicles();
        IEnumerable<IBooking> GetBookings();
    }
}
