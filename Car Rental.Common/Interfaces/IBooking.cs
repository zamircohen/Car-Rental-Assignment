namespace Car_Rental.Common.Interfaces
{
    public interface IBooking
    {
        string RegNo { get; set; }
        string Customer { get; set; }
        int KmRented { get; set; }
        int KmReturned { get; set; }
        DateTime Rented { get; set; }
        DateTime? Returned { get; set; }
        int TotalDaysRented { get; }
        int TotalKmRented { get; }
    }
}
