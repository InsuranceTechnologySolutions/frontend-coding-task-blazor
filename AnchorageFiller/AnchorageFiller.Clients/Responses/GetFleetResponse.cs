namespace AnchorageFiller.Clients.Responses;

public record GetFleetResponse(Size AnchorageSize, IReadOnlyList<FleetItem> Fleets);

public record FleetItem(Size SingleShipDimensions, string ShipDesignation, int ShipCount);

public record Size(int Width, int Height);