using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EchoApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public async Task Get()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("GET request received");
        }

        [HttpPost]
        public async Task Post()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("POST request received");
        }

        [HttpGet("Headers")]
        public async Task Headers()
        {
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(Request.Headers);
        }

        [HttpGet("Query")]
        public async Task Query()
        {
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(Request.Query);
        }

        [HttpPost("Body")]
        public async Task Body()
        {
            var bodyContent = await new StreamReader(Request.Body).ReadToEndAsync();
            Response.ContentType = "text/plain";
            await Response.WriteAsync(bodyContent);
        }
    }
}