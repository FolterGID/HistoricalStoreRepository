using HistoricalStore.Data.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalStore.Data.Models.SupplyModels.Types
{
    public class SouvenirType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Souvenir> Souvenirs { get; set; } = [];
    }
}
