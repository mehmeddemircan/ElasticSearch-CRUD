using ElasticSearch.Data.Entity;
using ElasticSearch.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElasticSearch.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IElasticSearchService _elasticSearchService; 

       

        public HomeController(IElasticSearchService elasticSearchService)
        {
            _elasticSearchService = elasticSearchService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {

            await InsertFullData();

            return Ok(); 
        }
        private async Task InsertFullData()
        {
            List<Cities> citiesList = new List<Cities>() {
            new Cities{City="Ankara",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=50000,Region="İç Anadolu"},
            new Cities{City="İzmir",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=30500,Region="Ege"},
            new Cities{City="Aydın",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=65000,Region="Ege"},
            new Cities{City="Rize",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=36522,Region="Karadeniz"},
            new Cities{City="İstanbul",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=25620,Region="Marmara"},
            new Cities{City="Sinop",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=50669,Region="Karadeniz"},
            new Cities{City="Kars",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=55500,Region="Doğu Anadolu"},
            new Cities{City="Van",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=55500,Region="Doğu Anadolu"},
            new Cities{City="Adıyaman",CreatedDate=System.DateTime.Now,Id=Guid.NewGuid().ToString(),Population=55500,Region="Güneydoğu Anadolu"},
            };
            await _elasticSearchService.InsertBulkDocuments("cities", citiesList);
        }
    }
}
