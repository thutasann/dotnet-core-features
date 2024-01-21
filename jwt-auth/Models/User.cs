using System;
using System.Collections.Generic;
namespace jwt_auth.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
    }
}