using System;
using System.Collections.Generic;
using System.Text;

namespace Pollify.Domain.Models
{
    public class User: Model
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
