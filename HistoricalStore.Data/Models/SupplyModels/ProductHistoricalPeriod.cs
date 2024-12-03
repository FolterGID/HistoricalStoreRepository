using HistoricalStore.Data.Models.ProductModels;

namespace HistoricalStore.Data.Models.SupplyModels
{
    public class ProductHistoricalPeriod
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int HistoricalPeriodId { get; set; }
        public HistoricalPeriod HistoricalPeriod { get; set; } = null!;
    }
}
