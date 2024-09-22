namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        public List<Guest> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuest(List<Guest> guests)
        {
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Guests quantity exceeds suite capacity.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsQuantity()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyHotelRate()
        {
            var valor = ReservedDays * Suite.DailyRatePrice;

            if (ReservedDays >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}