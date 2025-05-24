using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using TravelApi.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinationsController : ControllerBase
    {
        private readonly string _connectionString;

        public DestinationsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> GetDestinations(
            string category = null,
            int page = 1,
            int pageSize = 4)
        {
            try
            {
                // 验证输入参数
                if (page < 1) page = 1;
                if (pageSize < 1) pageSize = 4;
                if (pageSize > 50) pageSize = 50; // 限制最大页大小

                var destinations = new List<Destination>();
                var offset = (page - 1) * pageSize;

                using (var connection = new MySqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT * FROM destinations";
                    if (!string.IsNullOrEmpty(category))
                    {
                        query += " WHERE category = @Category";
                    }
                    query += " LIMIT @PageSize OFFSET @Offset";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(category))
                        {
                            command.Parameters.AddWithValue("@Category", category);
                        }
                        command.Parameters.AddWithValue("@PageSize", pageSize);
                        command.Parameters.AddWithValue("@Offset", offset);

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                destinations.Add(new Destination
                                {
                                    Id = reader.GetInt32("id"),
                                    Name = reader.GetString("name"),
                                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                        ? string.Empty
                                        : reader.GetString("description"),
                                    ImageUrl = reader.GetString("image_url"),
                                    Category = reader.GetString("category"),
                                    Price = reader.GetDecimal("price"),
                                    Rating = reader.GetDecimal("rating"),
                                    Tag = reader.GetString("tag")
                                });
                            }
                        }
                    }
                }

                return Ok(destinations);
            }
            catch (MySqlException ex)
            {
                // 记录数据库异常
                Console.WriteLine($"数据库错误: {ex.Message}");
                return StatusCode(500, "数据库连接错误，请稍后重试");
            }
            catch (Exception ex)
            {
                // 记录未知异常
                Console.WriteLine($"未知错误: {ex.Message}");
                return StatusCode(500, "服务器内部错误，请稍后重试");
            }
        }
    }
}