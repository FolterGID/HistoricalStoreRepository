namespace HistoricalStore.Data.Models.ProductModels
{
    public class Book : Product
    {
        public string Author { get; set; } = string.Empty;
        public int Pages { get; set; }
        public string Publisher { get; set; } = string.Empty;
    }

}