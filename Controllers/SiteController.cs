using System;
using System.Collections.Generic;
using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SitesApi.Models;

namespace SitesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SitesController : ControllerBase
    {

        private readonly ILogger<SitesController> _logger;

        public SitesController(ILogger<SitesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<SiteModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 50).Select(index => new SiteModel
            {
                Id = index,
                Name = $"{nameof(SiteModel.Name)}_{index}",
                AbbreviationName = $"{nameof(SiteModel.AbbreviationName)}_{index}",
                StateCode = "AZ"
            })
            .ToArray();
        }
    }
}
