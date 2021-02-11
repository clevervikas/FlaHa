using Microsoft.Extensions.DependencyInjection;
using FlaHaa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlaHa.Repository.Interfaces;

namespace Flahaa.Web.Utils
{
    public static class EFExtends
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<FlaHaaContext>(options => options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Flahaa.Web")));
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped(typeof(IRepo<>), typeof(Repo<>));
            return services;
        }
    }
}
