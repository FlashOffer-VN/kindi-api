using Kindi.API.Application.Common.Helpers;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;
using Kindi.API.Shared.Common.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Kindi.API.Infrastructure.Data;

public static class DatabaseSeeder
{
	public static async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
	{
		if (await context.Users.AnyAsync(u => u.Username == "admin", cancellationToken))
		{
			return;
		}

		var admin = new User
		{
			UserCode = CodeGenerator.Generate("USR"),
			Username = "admin",
			PasswordHash = PasswordHasher.Hash("Admin@123"),
			FullName = "Administrator",
			Email = "admin@kindi.com",
			Phone = "0987654321",
			IsActive = true,
			Role = UserRole.Admin
		};

		context.Users.Add(admin);
		await context.SaveChangesAsync(cancellationToken);
	}
}
