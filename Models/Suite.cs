namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(string suiteType, int capacity, decimal dailyRatePrice)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            DailyRatePrice = dailyRatePrice;
        }

        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal DailyRatePrice { get; set; }
    }
}