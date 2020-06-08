using System;
using System.Collections.Generic;
using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SitesApi.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace SitesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SitesController : ControllerBase
    {

        #region " Private Fields "

        private readonly ILogger<SitesController> _logger;

        #endregion

        #region " Constructors "

        public SitesController(ILogger<SitesController> logger)
        {
            _logger = logger;
        }

        #endregion

        #region " Api Implementation "

        [HttpGet]
        public IEnumerable<SiteModel> Get()
        {
            using (SqlConnection connection = new SqlConnection(Constants.ConnectionStrings.Hub))
            {
                return connection.Query<SiteModel>(Constants.Queries.GetAll).ToArray();
            }
        }

        #endregion

        #region " Private Functions "

        #endregion

        #region " Constants "

        private static class Constants
        {
            internal static class ConnectionStrings
            {
                internal const string Hub = @"Data Source=.\SqlExpress;Database=Hub;Integrated Security=SSPI;MultipleActiveResultSets=True;";
                internal const string AppData = @"Data Source=.\SqlExpress;Database=AppData;Integrated Security=SSPI;MultipleActiveResultSets=True;";
                internal const string AppDataCache = @"Data Source=.\SqlExpress;Database=AppDataCache;Integrated Security=SSPI;MultipleActiveResultSets=True;";
            }
            internal static class Queries
            {
                internal const string GetAll = @"
                    SELECT 
                        Id
                        ,Name
                        ,StateCode
                        ,LastTrans
                        ,LastSoc
                        ,LastHealthMsg
                        ,LastCreds
                        ,LastPullIn 
                        ,MinSoftwareVersion
                        ,SoftwareVersion
                        ,EmailIdList
                    FROM Sites
                ";
            }
        }

        #endregion

    }
}
