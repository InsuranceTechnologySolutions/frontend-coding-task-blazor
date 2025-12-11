using System.Net.Http.Json;
using AnchorageFiller.Clients.Responses;

namespace AnchorageFiller.Clients;

public class FleetsClient(HttpClient client) : IFleetsClient
{
    public async Task<GetFleetResponse> GetRandomFleetAsync(CancellationToken cancellationToken = default)
    {
        var response = await client.GetFromJsonAsync<GetFleetResponse>("/api/fleets/random", cancellationToken);
        return response ?? throw new("Failed to retrieve fleet data.");
    }
}
