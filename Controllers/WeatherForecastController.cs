using Microsoft.AspNetCore.Mvc;

namespace kafka_mongo_issue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public TestController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}
