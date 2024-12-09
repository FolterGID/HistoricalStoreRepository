using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalStore.Data.Models.ProductModels
{
    public class Clothing : Product
    {
        public int ClothingTypeId { get; set; }
        public string Size { get; set; } = string.Empty;
        public string FabricType { get; set; } = string.Empty;
    }
}
