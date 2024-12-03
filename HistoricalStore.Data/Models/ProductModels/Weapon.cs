namespace HistoricalStore.Data.Models.ProductModels
{
    public class Weapon : Product
    {
        public string WeaponType { get; set; } = string.Empty;
        public double Weight { get; set; }
        public double Length { get; set; }
        public bool IsSharp { get; set; }
    }
}
