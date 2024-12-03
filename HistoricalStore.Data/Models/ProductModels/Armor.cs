namespace HistoricalStore.Data.Models.ProductModels
{
    public class Armor : Product
    {
        public string ArmorType { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public double Weight { get; set; }
    }
}
