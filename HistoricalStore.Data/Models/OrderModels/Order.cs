using HistoricalStore.Data.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace HistoricalStore.Data.Models.OrderModels
{
    public class Order
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Precision(18, 2)]
        public decimal TotalPrice { get; set; }
        public int OrderStatusId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = [];
    }
}
