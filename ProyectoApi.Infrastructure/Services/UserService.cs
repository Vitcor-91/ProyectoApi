
using ProyectoApi.Infrastructure.Persistence;

namespace ProyectoApi.Infrastructure.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Database_IsAccessible()
        {
            var result = await _context.Database.CanConnectAsync();
            return result;
        }
    }
}