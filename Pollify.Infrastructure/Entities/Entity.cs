using System;
using System.Collections.Generic;
using System.Text;

namespace Pollify.Infrastructure.Entities
{
    public abstract class Entity
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
