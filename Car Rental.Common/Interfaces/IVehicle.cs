namespace Car_Rental.Common.Interfaces
{
    public interface IVehicle
    {
        string RegNo { get; set; }
        string Make { get; set; }
        int Odometer { get; set; }
        double CostKm { get; set; }
        int CostDay { get; set; }
        string Image { get; set; }
        string Type { get; set; }
        bool Status { get; set; }
    }
}
