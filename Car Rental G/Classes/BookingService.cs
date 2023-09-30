namespace Car_Rental_G.Classes
{
    public class Booking
    {
        public string RegNo { get; set; } = "";
        public string Customer { get; set; } = "";
        public int KmRented { get; set; }     
        public int KmReturned { get; set; }
        public DateTime Rented { get; set; }
        public DateTime? Returned { get; set; }
        public double Cost { get; set; }
    }
}
