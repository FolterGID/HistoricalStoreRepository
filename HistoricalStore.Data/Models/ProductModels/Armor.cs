namespace HistoricalStore.Data.Models.ProductModels
{
    public class Armor : Product
    {
        public int ArmorTypeId { get; set; }
        public string Size { get; set; } = string.Empty;
        public double Weight { get; set; }
    }
}
