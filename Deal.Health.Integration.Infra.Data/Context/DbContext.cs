using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Deal.Health.Integration.Infra.Data.Context
{
    public class DbContext: IAsyncDisposable
    {
        public MySqlConnection Connection { get; set; }

        public DbContext(IConfiguration configuration)
        {
            Connection = new MySqlConnection(configuration.GetConnectionString("Default"));
            Connection.Open();
        }

        public async ValueTask DisposeAsync()
        {
            await Connection.CloseAsync();
            await Connection.ClearAllPoolsAsync();
            await Connection.DisposeAsync();
        }
    }
}
