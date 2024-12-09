using HistoricalStore.Data.Models.ProductModels;

namespace HistoricalStore.Data.Models.SupplyModels.Types
{
    public class ArmorType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Armor> Armors { get; set; } = [];
    }
}
