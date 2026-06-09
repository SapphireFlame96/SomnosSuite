using Dapper;
using SomnosSuite.Application.Abstractions;

namespace SomnosSuite.Application.StunningDevices.GetAllStunningDevices
{
    public class GetAllStunningDevicesQueryHandler(ISqlConnectionFactory sqlConnectionFactory) : IQueryHandler<GetAllStunningDevicesQuery, List<GetAllStunningDevicesDto>>
    {
        public async Task<List<GetAllStunningDevicesDto>> Handle(GetAllStunningDevicesQuery request, CancellationToken cancellationToken)
        {
            const string query = @"
            SELECT
                Id,
                DeviceType,
                Model,
                SerialNumber,
                AnimalCategory
            FROM StunningDevices
            WHERE IsDeleted = 0
            ORDER BY Model, SerialNumber;";

            using var connection = sqlConnectionFactory.GetOpenConnection();
            return (await connection.QueryAsync<GetAllStunningDevicesDto>(query, cancellationToken)).AsList();
        }
    }
}