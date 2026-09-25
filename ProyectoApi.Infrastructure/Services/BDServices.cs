

using ProyectoApi.Application.Interfaces;
using ProyectoApi.Infrastructure.Persistence;

namespace ProyectoApi.Infrastructure.Services
{
    public class BDService : IConnectionRepository
    {
        private readonly AppDbContext _context;

        public BDService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Database_IsAccessible(
            CancellationToken cancellationToken
        )
        {
            var result = await _context.Database.CanConnectAsync();
            return result;
        }
    }
}