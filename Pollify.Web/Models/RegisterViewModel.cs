using Pollify.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pollify.Web.Models
{
    public class RegisterViewModel: Model
    {
        [Required, EmailAddress]
        public string Email{ get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Password != ConfirmPassword)
            {
                var props = new[] { nameof(Password), nameof(ConfirmPassword) };
                yield return new ValidationResult("Passwords do not match", props);
            }
        }
    }
}
