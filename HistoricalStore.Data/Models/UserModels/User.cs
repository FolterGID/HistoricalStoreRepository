using HistoricalStore.Data.Models.OrderModels;
using Microsoft.AspNetCore.Identity;

namespace HistoricalStore.Data.Models.UserModels
{
    public class User : IdentityUser
    {
        /*public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int RoleId { get; set; }*/
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public List<Order> Orders { get; set; } = [];
    }

}