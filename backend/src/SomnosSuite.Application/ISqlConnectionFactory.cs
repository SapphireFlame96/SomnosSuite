using System.Data;

namespace SomnosSuite.Application
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
        IDbConnection GetOpenConnection();
        string ConnectionString();
    }
}