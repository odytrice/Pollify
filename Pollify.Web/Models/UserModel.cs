using Microsoft.AspNetCore.Identity;
using Pollify.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollify.Web.Models
{
    public class UserModel: IdentityUser<string>
    {

    }
}
