namespace HistoricalStore.Data.Models.SupplyModels
{
    public class HistoricalPeriod
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ProductHistoricalPeriod> ProductHistoricalPeriods { get; set; } = [];
    }

}
