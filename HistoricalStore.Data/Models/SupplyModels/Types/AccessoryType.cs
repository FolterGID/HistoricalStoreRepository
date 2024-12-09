using HistoricalStore.Data.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalStore.Data.Models.SupplyModels.Types
{
    public class AccessoryType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Accessory> Accessories { get; set; } = [];

    }
}
