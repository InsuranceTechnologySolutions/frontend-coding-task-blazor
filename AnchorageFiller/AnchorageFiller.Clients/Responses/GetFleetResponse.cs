namespace AnchorageFiller.Clients.Responses;

public record GetFleetResponse(Size AnchorageSize, IReadOnlyList<FleetItem> Fleets);
