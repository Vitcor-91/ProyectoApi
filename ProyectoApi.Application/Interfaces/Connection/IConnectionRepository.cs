
namespace ProyectoApi.Application.Interfaces;

public interface IConnectionRepository
{
    Task<bool> Database_IsAccessible(
        CancellationToken cancellationToken
    );
}
