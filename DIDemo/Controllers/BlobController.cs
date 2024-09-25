using DIDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobController : ControllerBase
    {
        private readonly IStorageService storageService;

        public BlobController(IEnumerable<IStorageService> storageServices)
        {
            this.storageService = storageServices.Single(x => x is BlobStorageService );
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(storageService.GetStorageInfo());
        }
    }
}
