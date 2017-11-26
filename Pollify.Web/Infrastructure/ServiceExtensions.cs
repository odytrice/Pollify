using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pollify.Domain.Interface.Repositories;
using Pollify.Infrastructure.Repositories;
using Pollify.Web.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollify.Web.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            //Data
            services.AddScoped<DbContext, DataEntities>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
