using ItSupport.Data;
using ItSupport.Interfaces;
using ItSupport.Services;
using Microsoft.EntityFrameworkCore;

namespace ItSupport.Extensions
{
	public static class ApplicationServiceExtensions 
	{
		public static IServiceCollection AddapplicationServices(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContext<DataContext>(opt =>
			{
				opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
			});

			services.AddCors();

			services.AddScoped<ITokenService, TokenService>();
			return services;
		}
	}
}
