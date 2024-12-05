using HistoricalStore.Data.Models.OrderModels;

namespace HistoricalStore.Data.Models.UserModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public List<Order> Orders { get; set; } = [];
    }

}