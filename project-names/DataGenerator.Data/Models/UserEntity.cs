﻿namespace DataGenerator.Data.Models
{
    public class UserEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
}