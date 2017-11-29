using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pollify.Domain.Interface.Repositories;
using Pollify.Infrastructure.Repositories;
using Pollify.Web.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Pollify.Web
{
    public static class DatabaseExtensions
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DataEntities");
            var migrationAssembly = typeof(DataEntities).GetTypeInfo().Assembly.GetName().Name;
            services.AddDbContext<DataEntities>(options => options.UseSqlServer(connectionString, opt => opt.MigrationsAssembly(migrationAssembly)));
        }

        public static void MigrateDatabase(this IServiceProvider app)
        {
            using (var serviceScope = app.GetService<IServiceScopeFactory>().CreateScope())
            {
                var application = serviceScope.ServiceProvider.GetRequiredService<DataEntities>();
                application.Database.Migrate();
            }
        }
    }
}
