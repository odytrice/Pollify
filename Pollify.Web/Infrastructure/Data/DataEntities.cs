using Microsoft.EntityFrameworkCore;
using Pollify.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollify.Web.Infrastructure.Data
{
    public class DataEntities: DbContext
    {
        public DataEntities() { }
        public DataEntities(DbContextOptions<DataEntities> options) : base(options) { }
        public DbSet<UserEntity> Users { get; set; }
    }
}
