﻿namespace Aqsha.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Credit> Credits { get; set; }
    }
}
