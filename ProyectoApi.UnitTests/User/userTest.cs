using Microsoft.EntityFrameworkCore;
using ProyectoApi.Infrastructure.Persistence;

namespace ProyectoApi.UnitTests.User;

public class UserTest
{
    [Fact]
    public async Task Database_CanConnect()
    {
        var connectionString =
            Environment.GetEnvironmentVariable(
                "ConnectionStrings__DefaultConnection");

        Assert.False(
            string.IsNullOrWhiteSpace(connectionString),
            "No se encontró ConnectionStrings__DefaultConnection.");

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString))
            .Options;

        await using var context = new AppDbContext(options);

        var result = await context.Database.CanConnectAsync();

        Assert.True(result);
    }
}