using SomnosSuite.Application.Abstractions;
using SomnosSuite.Application.StunningDevices.GetAllStunningDevices;

namespace SomnosSuite.Application.StunningDevices
{
    public record GetAllStunningDevicesQuery : IQuery<List<GetAllStunningDevicesDto>>
    {
    }
}