using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class AppAdditionalServices
    {
        public static IServiceCollection AppAdditionals(this IServiceCollection services , IConfiguration _config)
        {
              services.AddScoped<ITokenInterface,TokenService>();
            services.AddDbContext<userdata>
            ( options => {options.UseSqlite(_config.GetConnectionString("DefaultConnection")); } );

            return services;
               
        }
        
    }
}