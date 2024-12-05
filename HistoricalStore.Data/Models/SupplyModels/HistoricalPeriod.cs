﻿using HistoricalStore.Data.Models.ProductModels;

namespace HistoricalStore.Data.Models.SupplyModels
{
    public class HistoricalPeriod
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = [];
    }

}
