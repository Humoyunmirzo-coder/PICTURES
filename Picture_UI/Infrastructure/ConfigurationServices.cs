using Aplication.Services;
using Domain.Users;
using Infrastructure.DataAction;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static  class ConfigurationServices
    {
        public static void AddinfrastructureServices ( this IServiceCollection services  , IConfiguration configuration)
        {
            services.AddScoped<IUser , UserServise> ();
            services.AddDbContext<UserDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("PictureConfuguration")));
        }
    }
}
