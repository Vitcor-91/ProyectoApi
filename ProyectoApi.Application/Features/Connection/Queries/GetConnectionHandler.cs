using ProyectoApi.Application.DTOs.User;
using ProyectoApi.Application.Interfaces;

namespace Prueba.Application.Queries.Users;

public class GetConnectionHandler
{
    private readonly IConnectionRepository _repository;

    public GetConnectionHandler(IConnectionRepository repository)
    {
        _repository = repository;
    }

    public async Task<TestConection> Handle(
        CancellationToken cancellationToken)
    {
        var isAccessible = await _repository.Database_IsAccessible(cancellationToken);

        var messagge = isAccessible == true ? "Hay conexión a la BD" : "No hay conexión a la BD";
        
        return new TestConection
        {
            success = isAccessible,
            message = messagge
        };
    }
}