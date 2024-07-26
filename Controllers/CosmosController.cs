using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from CosmosController!");
            //
        }

        [HttpPost] 
      public async Task<IActionResult> PostAsync()
        {
            // loop a thousand times adding a floating point number with a random value
            for (int i = 0; i < 1000; i++)
            {
                YourEntity entity = new YourEntity
                {
                    Id = Guid.NewGuid().ToString(),
                    PartitionKey = "MyPartitionKey",
                    // Add other properties here
                };
            }
            return StatusCode(StatusCodes.Status201Created);
        }
    }

    public class YourEntity
    {
        public string Id { get; set; }
        public string PartitionKey { get; set; }
        // Add other properties here
    }
}
