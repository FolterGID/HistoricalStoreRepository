namespace HistoricalStore.Data.Models.ProductModels
{
    public class Weapon : Product
    {
        public int WeaponTypeId { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public bool IsSharp { get; set; } = false;
    }
}
