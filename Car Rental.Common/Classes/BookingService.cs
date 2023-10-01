namespace Car_Rental.Classes
{
    public class Booking : Common.Interfaces.IBooking
    {
        public string RegNo { get; set; } = "";
        public string Customer { get; set; } = "";
        public int KmRented { get; set; }
        public int KmReturned { get; set; }
        public DateTime Rented { get; set; }
        public DateTime? Returned { get; set; }

        public int TotalDaysRented
        {
            get
            {
                if (Returned.HasValue)
                {
                    TimeSpan rentalDuration = Returned.Value - Rented;
                    int daysRented = rentalDuration.Days;
                    return daysRented;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int TotalKmRented
        {
            get
            {
                int kmRented = KmReturned - KmRented;
                return kmRented;
            }
        }
    }
}
