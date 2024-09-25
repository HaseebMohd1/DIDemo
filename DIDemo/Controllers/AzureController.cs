using DIDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzureController : ControllerBase
    {
        private readonly IStorageService storageService;
        private readonly IQueueService queueService;

        public AzureController(IEnumerable<IStorageService> storageServices, [FromKeyedServices("azure")]IQueueService queueService)
        {
            this.storageService = storageServices.Single(x => x is BlobStorageService );
            this.queueService = queueService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(storageService.GetStorageInfo());
        }

        [HttpGet("queue")]
        public IActionResult GetQueue()
        {
            return Ok(queueService.GetQueueInfo());
        }
    }
}
