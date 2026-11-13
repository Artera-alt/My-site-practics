using System.Data;
using System.Data.SqlClient;
using Практика_ASP.NET.Models;
using static Практика_ASP.NET.Models.Workforce;

namespace Практика_ASP.NET.Controllers
{
    public class WorkforceRepository
    {
            private readonly string _connectionString;

            public WorkforceRepository(IConfiguration configuration)
            {
                _connectionString = configuration.GetConnectionString("DefaultConnection");
            }

            public async Task<List<Workforce>> GetWorkforceAsync()
            {
                var Workforce = new List<Workforce>();

                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var command = new SqlCommand(
                        "SELECT * FROM [dbo].[Workforce]", connection);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int Id = reader.GetInt32(0);
                            string FullName = reader.GetString(1);
                            WorkerRole WorkerRole = (WorkerRole)Enum.Parse(typeof(WorkerRole),reader.GetString(2));
                            Workforce.Add(new Workforce(Id, FullName, WorkerRole));

                        }
                    }
                }
                return Workforce;
            }
            public async Task<Workforce?> GetWorkforceByIdAsync(int id, string FullName, WorkerRole WorkerRole)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    var command = new SqlCommand(
                        "SELECT * FROM [dbo].[Workforce] WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                        return new Workforce(id, FullName, WorkerRole);
                        }
                        return null;
                    }
                }
            }
    }
}


