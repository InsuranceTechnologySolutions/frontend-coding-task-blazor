using AnchorageFiller.Clients.Responses;

namespace AnchorageFiller.Clients;

public interface IFleetsClient
{
    Task<GetFleetResponse?> GetRandomFleetAsync(CancellationToken cancellationToken = default);
}