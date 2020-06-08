using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using SitesApi.Models;

public class SiteStatusRepository : ISiteStatusModelRepository
{

    private readonly ILogger _logger;
    private readonly SqlConnection _connection;

    public SiteStatusRepository(ILogger logger, SqlConnection connection)
    {
        _logger = logger;
        _connection = connection;
    }

    public int Add(SiteStatusModel entity)
    {
        throw new System.NotImplementedException();
    }

    public async Task<int> AddAsync(SiteStatusModel entity)
    {
        return await _connection.ExecuteAsync(Constants.Queries.Add, entity);
    }

    public void Delete(int entity)
    {
        throw new System.NotImplementedException();
    }

    public IEnumerable<SiteStatusModel> GetAll()
    {
        throw new System.NotImplementedException();
    }

    public async Task<IEnumerable<SiteStatusModel>> GetAllAsync()
    {
        return await _connection.QueryAsync<SiteStatusModel>(Constants.Queries.GetAll);
    }

    public SiteStatusModel GetById(int Id)
    {
        throw new System.NotImplementedException();
    }

    public void Update(SiteStatusModel entity)
    {
        throw new System.NotImplementedException();
    }

    private static class Constants
    {
        internal static class Queries
        {
            internal const string GetById = GetAll + " WHERE Id=@Id";

            internal const string GetAll = @"
                SELECT 
                    Id
                    ,Name
                    ,State
                    ,VehicleStatus
                    ,PclStatus
                    ,HealthStatus
                    ,OnlineStatus
                    ,StationStatus 
                    ,LastUpdateTime
                FROM SiteStatuses";

            internal const string Add = @"
                INSERT INTO SiteStatuses(
                    Name
                    ,State
                    ,VehicleStatus
                    ,PclStatus
                    ,HealthStatus
                    ,OnlineStatus
                    ,StationStatus 
                    ,LastUpdateTime
                ) VALUES(
                    @Name
                    ,@State
                    ,@VehicleStatus
                    ,@PclStatus
                    ,@HealthStatus
                    ,@OnlineStatus
                    ,@StationStatus 
                    ,@LastUpdateTime
                );";

            internal const string Delete = @"
                DELETE FROM SiteStatuses 
                WHERE Id=@Id;";

            internal const string Update = @"
                ;";

        }
    }
}