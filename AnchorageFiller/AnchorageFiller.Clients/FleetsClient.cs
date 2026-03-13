using System.Net.Http.Json;
using AnchorageFiller.Clients.Responses;

namespace AnchorageFiller.Clients;

public class FleetsClient(HttpClient client) : IFleetsClient
{
    public Task<GetFleetResponse?> GetRandomFleetAsync(CancellationToken cancellationToken = default) =>
        client.GetFromJsonAsync<GetFleetResponse>("/api/fleets/random", cancellationToken);
}
