using HistoricalStore.Data.Models.ProductModels;

namespace HistoricalStore.Data.Models.SupplyModels
{
    public class ProductMaterial
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int MaterialId { get; set; }
        public Material Material { get; set; } = null!;
    }

}