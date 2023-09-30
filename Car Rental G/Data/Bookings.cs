using Car_Rental_G.Classes;
using System;
using System.Collections.Generic;

namespace Car_Rental_G.Data
{
    public static class BookingsDatabase
    {
        public static List<Booking> bookings { get; } = new List<Booking>
        {
            new Booking { RegNo = "ABC123", Customer = "Michael Savage", KmRented = 10000, KmReturned = 15000, Rented = DateTime.Now},
            new Booking { RegNo = "DEF456", Customer = "John Doe", KmRented = 20000, KmReturned = 30000, Rented = new DateTime(2023, 8, 15, 8, 0, 0), Returned = new DateTime(2023, 8, 20, 8, 0, 0)},
        };
        static BookingsDatabase()
        {
            foreach (var booking in bookings)
            {
                var vehicle = VehiclesDatabase.vehicles.Find(v => v.RegNo == booking.RegNo);
                if (vehicle != null)
                {
                    booking.Cost = BookingProcessor.CalculateCost(booking, vehicle);
                }
            }
        }
    }
}

