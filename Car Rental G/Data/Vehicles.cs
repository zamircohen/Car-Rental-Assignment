using Car_Rental_G.Classes;

namespace Car_Rental_G.Data
{
    public static class VehiclesDatabase
    {
        public static List<Vehicle> vehicles { get; } = new List<Vehicle>
    {
        new Vehicle { RegNo = "ABC123", Make = "Volkswagen", Odometer = 10000, CostKm = 1, CostDay = 200, Image = "https://imgd.aeplcdn.com/664x374/n/cw/ec/144681/virtus-exterior-right-front-three-quarter.jpeg?isig=0&q=80&q=80", Type = "Combi"},
        new Vehicle { RegNo = "DEF456", Make = "BMW", Odometer = 20000, CostKm = 1, CostDay = 100, Image = "https://cdni.autocarindia.com/utils/imageresizer.ashx?n=https://cms.haymarketindia.net/model/uploads/modelimages/BMW-2-Series-Gran-Coupe-271220221147.jpg", Type = "Sedan"},
        new Vehicle { RegNo = "GHI789", Make = "Audi", Odometer = 5000, CostKm = 3, CostDay = 200, Image = "https://cdni.autocarindia.com/utils/imageresizer.ashx?n=https://cms.haymarketindia.net/model/uploads/modelimages/Audi-A4-190120211207.jpg&w=350&h=251&q=90&c=1", Type = "Combi", Status = false},
        new Vehicle { RegNo = "JKL012", Make = "Jeep", Odometer = 3000, CostKm = 1.5, CostDay = 300, Image = "https://cdn.jdpower.com/Models/320x240/2023-Jeep-Compass.jpg", Type = "SUV"},
        new Vehicle { RegNo = "MNO234", Make = "Yamaha", Odometer = 300000, CostKm = 0.5, CostDay = 50, Image = "https://cdn2.yamaha-motor.eu/prod/product-assets/2023/MT07A/2023-Yamaha-MT07A-EU-Icon_Blue-Studio-001-03.jpg", Type = "Motorcycle"}
    };

    }
}
