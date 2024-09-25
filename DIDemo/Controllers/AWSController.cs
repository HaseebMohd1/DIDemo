using DIDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AWSController : ControllerBase
    {
        private readonly IStorageService storageService;
        private readonly IQueueService queueService;

        public AWSController(IEnumerable<IStorageService> storageServices, [FromKeyedServices("aws")]IQueueService queueService)
        {
            this.storageService = storageServices.Single(x => x is S3StorageService);
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
