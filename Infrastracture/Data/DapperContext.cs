using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Infrastracture.Data;

public class DapperContext(IConfiguration configuration)
{
    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(configuration.GetConnectionString("Default"));
    }
}