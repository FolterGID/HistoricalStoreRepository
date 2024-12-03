﻿namespace HistoricalStore.Data.Models.UserModels
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<User> Users { get; set; } = [];
    }
}