using Car_Rental_G.Data;
using System;
using System.Collections.Generic;

namespace Car_Rental_G.Classes
{
    public class BookingProcessor
    {
        public static double CalculateCost(Booking booking, Vehicle vehicle)
        {
            TimeSpan rentalPeriod = booking.Returned.HasValue
                ? booking.Returned.Value - booking.Rented
                : DateTime.Now - booking.Rented;

            int totalDaysRented = (int)rentalPeriod.TotalDays;

            double cost = totalDaysRented * vehicle.CostDay + (vehicle.CostKm * (booking.KmReturned - booking.KmRented));

            return cost;
        }
    }
}
