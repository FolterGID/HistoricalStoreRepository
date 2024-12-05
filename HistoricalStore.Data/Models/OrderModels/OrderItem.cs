using HistoricalStore.Data.Models.ProductModels;

namespace HistoricalStore.Data.Models.OrderModels
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
    }

}
