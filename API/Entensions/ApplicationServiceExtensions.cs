using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Entensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationExtensions(this IServiceCollection services,IConfiguration config){
             services.AddScoped<ITokenService, TokenService>();

            //Adding Database Connection 
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}