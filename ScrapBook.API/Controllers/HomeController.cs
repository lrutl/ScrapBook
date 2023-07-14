using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using ScrapBook.Common.Models;

namespace ScrapBook.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRelationships")]
        public IEnumerable<Relationship> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Relationship
            {
            })
            .ToArray();
        }
    }
}