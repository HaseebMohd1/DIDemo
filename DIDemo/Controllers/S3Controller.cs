using DIDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class S3Controller : ControllerBase
    {
        private readonly IStorageService storageService;

        public S3Controller(IEnumerable<IStorageService> storageServices)
        {
            this.storageService = storageServices.Single(x => x is S3StorageService);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(storageService.GetStorageInfo());
        }
    }
}
