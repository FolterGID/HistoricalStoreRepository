﻿using HistoricalStore.Data.Models.SupplyModels;

namespace HistoricalStore.Data.Models.ProductModels
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsAvailable { get; set; }
        public List<Material> Materials { get; set; } = [];
        public List<HistoricalPeriod> HistoricalPeriods { get; set; } = [];
    }
}
