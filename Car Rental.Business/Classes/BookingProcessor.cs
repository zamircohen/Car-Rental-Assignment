using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business
{
    public class BookingProcessor
    {
        private readonly IData dataService;
        public BookingProcessor(IData dataService)
        {
            this.dataService = dataService;
        }
        public static double CalculateCost(IBooking booking, IVehicle vehicle)
        {
            TimeSpan rentalPeriod = booking.Returned.HasValue ? booking.Returned.Value - booking.Rented : DateTime.Now - booking.Rented;

            int totalDaysRented = (int)rentalPeriod.TotalDays;

            totalDaysRented = totalDaysRented > 0 ? totalDaysRented : 1;

            double cost = booking.TotalKmRented * vehicle.CostKm + (totalDaysRented * vehicle.CostDay);

            return cost;
        }

        public IEnumerable<ICustomer> GetCustomers()
        {
            return dataService.GetCustomers();
        }

        public IEnumerable<IVehicle> GetVehicles()
        {
            return dataService.GetVehicles();
        }

        public IEnumerable<IBooking> GetBookings()
        {
            return dataService.GetBookings();
        }

    }
}


