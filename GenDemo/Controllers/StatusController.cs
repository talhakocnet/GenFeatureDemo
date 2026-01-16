using Microsoft.AspNetCore.Mvc;

namespace GenDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        // GET: /api/status
        private static readonly DateTime _startTime = DateTime.UtcNow;

        [HttpGet]
        public IActionResult GetStatus()
        {
            var result = new {
                status = "ok",
                version = "1.0.0",
                timestamp = DateTime.UtcNow.ToString("o"),
                environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Unknown",
                uptimeSeconds = (int)(DateTime.UtcNow - _startTime).TotalSeconds
            };
            return Ok(result);
        }
    }
}
