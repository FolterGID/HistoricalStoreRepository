using HistoricalStore.Data.Models.ProductModels;

namespace HistoricalStore.Data.Models.SupplyModels
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = [];
    }
}
