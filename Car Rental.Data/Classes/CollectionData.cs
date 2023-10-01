using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using Car_Rental.Classes;
using Car_Rental.Data.Interfaces;
using Car_Rental.Common.Enums;

namespace Car_Rental.Data.Classes
{
    public class CollectionData : IData
    {
        private readonly List<ICustomer> _customers = new List<ICustomer>();
        private readonly List<IVehicle> _vehicles = new List<IVehicle>();
        private readonly List<IBooking> _bookings = new List<IBooking>();

        public CollectionData()
        {
            SeedData();
        }

        public void SeedData()
        {
            _customers.AddRange(new List<ICustomer>
            {
                new Customer { FirstName = "Michael", LastName = "Savage", SSN = 12345 },
                new Customer { FirstName = "Nicole", LastName = "Cohen", SSN = 46567 },
                new Customer { FirstName = "John", LastName = "Doe", SSN = 98765 }
            });

            _vehicles.AddRange(new List<IVehicle>
            {
                new Vehicle { RegNo = "ABC123", Make = "Volkswagen", Odometer = 10000, CostKm = 1, CostDay = 200, Image = "https://imgd.aeplcdn.com/664x374/n/cw/ec/144681/virtus-exterior-right-front-three-quarter.jpeg?isig=0&q=80&q=80", Type = VehicleTypes.Combi.ToString() },
                new Vehicle { RegNo = "DEF456", Make = "BMW", Odometer = 20000, CostKm = 1, CostDay = 100, Image = "https://cdni.autocarindia.com/utils/imageresizer.ashx?n=https://cms.haymarketindia.net/model/uploads/modelimages/BMW-2-Series-Gran-Coupe-271220221147.jpg", Type = VehicleTypes.Sedan.ToString() },
                new Vehicle { RegNo = "GHI789", Make = "Audi", Odometer = 5000, CostKm = 3, CostDay = 200, Image = "https://cdni.autocarindia.com/utils/imageresizer.ashx?n=https://cms.haymarketindia.net/model/uploads/modelimages/Audi-A4-190120211207.jpg&w=350&h=251&q=90&c=1", Type = VehicleTypes.Combi.ToString(), Status = false },
                new Vehicle { RegNo = "JKL012", Make = "Jeep", Odometer = 3000, CostKm = 1.5, CostDay = 300, Image = "https://cdn.jdpower.com/Models/320x240/2023-Jeep-Compass.jpg", Type = VehicleTypes.SUV.ToString() },
                new Vehicle { RegNo = "MNO234", Make = "Yamaha", Odometer = 300000, CostKm = 0.5, CostDay = 50, Image = "https://cdn2.yamaha-motor.eu/prod/product-assets/2023/MT07A/2023-Yamaha-MT07A-EU-Icon_Blue-Studio-001-03.jpg", Type = VehicleTypes.Motorcycle.ToString() }
            });

            _bookings.AddRange(new List<IBooking>
            {
                new Booking { RegNo = "ABC123", Customer = "Michael Savage", KmRented = 10000, Rented = DateTime.Now},
                new Booking { RegNo = "DEF456", Customer = "John Doe", KmReturned = 30000, Rented = new DateTime(2023, 8, 15, 8, 0, 0), Returned = new DateTime(2023, 8, 20, 8, 0, 0)},
                new Booking { RegNo = "GHI789", Customer = "Nicole Cohen", KmReturned = 6000, Rented = new DateTime(2023, 8, 15, 8, 0, 0), Returned = new DateTime(2023, 8, 16, 8, 0, 0)}
            });
        }

        public IEnumerable<ICustomer> GetCustomers() => _customers;
        public IEnumerable<IVehicle> GetVehicles() => _vehicles;
        public IEnumerable<IBooking> GetBookings() => _bookings;
    }
}
