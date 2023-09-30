namespace Car_Rental_G.Classes

{ 
    public class Vehicle
    {
        public string RegNo { get; set; } = "";
        public string Make { get; set; } = "";
        public int Odometer { get; set; }
        public double CostKm { get; set; }
        public int CostDay { get; set; }
        public string Image { get; set; } = "";
        public string Type { get; set; } = "";
        public bool Status { get; set; } = true;
    }
}