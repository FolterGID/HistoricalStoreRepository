using HistoricalStore.Data.Models.SupplyModels;

namespace HistoricalStore.Data.Models.ProductModels
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public List<ProductMaterial> ProductMaterials { get; set; } = [];
        public List<ProductHistoricalPeriod> ProductHistoricalPeriods { get; set; } = [];
    }

}
