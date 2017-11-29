using System;
using System.Collections.Generic;
using System.Text;

namespace Pollify.Domain.Models
{
    public class User: Model
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
    }
}
