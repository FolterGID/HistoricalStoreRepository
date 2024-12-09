using Microsoft.AspNetCore.Identity;

namespace HistoricalStore.Data.Models.UserModels
{
    public class Role : IdentityRole
    {
        public List<User> Users { get; set; } = [];
    }
}