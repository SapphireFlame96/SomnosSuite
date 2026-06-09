namespace SomnosSuite.Application.StunningDevices.GetAllStunningDevices
{
    public record GetAllStunningDevicesDto(
        Guid Id,
        string DeviceType,
        string Model,
        string SerialNumber,
        string AnimalCategory
    )
    {
        
    }
}