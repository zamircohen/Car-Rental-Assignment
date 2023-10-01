//BookingProcessor.cs
using Car_Rental.Classes;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Business
{
    public class BookingProcessor
    {
        public static double CalculateCost(IBooking booking, IVehicle vehicle)
        {
            TimeSpan rentalPeriod = booking.Returned.HasValue ? booking.Returned.Value - booking.Rented : DateTime.Now - booking.Rented;

            int totalDaysRented = (int)rentalPeriod.TotalDays;

            totalDaysRented = totalDaysRented > 0 ? totalDaysRented : 1;

            double cost = booking.TotalKmRented * vehicle.CostKm + (totalDaysRented * vehicle.CostDay);

            return cost;
        }
    }
}


