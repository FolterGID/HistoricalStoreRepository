using HistoricalStore.Data.Models.UserModels;

namespace HistoricalStore.Data.Models.OrderModels
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; } = null!;
        public List<OrderItem> OrderItems { get; set; } = [];
    }

}
