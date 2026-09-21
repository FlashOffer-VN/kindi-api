using Kindi.API.Application.Common.Interfaces;
using Kindi.API.Domain.Interfaces;
using Kindi.API.Infrastructure.Data;
using Kindi.API.Infrastructure.Repositories;
using Kindi.API.Infrastructure.Services;
using Kindi.API.Shared.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kindi.API.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructureServices(
		this IServiceCollection services,
		IConfiguration configuration)
	{
		// Database context
		services.AddDbContext<ApplicationDbContext>(options =>
			options.UseNpgsql(
				configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

		services.AddScoped<IApplicationDbContext>(provider =>
			provider.GetRequiredService<ApplicationDbContext>());

		// Generic repository
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

        // Current User Service
        services.AddScoped<ICurrentUserService, CurrentUserService>();

		// HttpContextAccessor
		services.AddHttpContextAccessor();

		services.AddScoped<IExcelService, ExcelService>();

		return services;
	}
}
