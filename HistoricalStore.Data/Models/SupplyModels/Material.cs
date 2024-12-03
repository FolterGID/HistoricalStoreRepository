namespace HistoricalStore.Data.Models.SupplyModels
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ProductMaterial> ProductMaterials { get; set; } = [];
    }

}
