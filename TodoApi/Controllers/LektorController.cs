using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LektorController : ControllerBase
    {
        private ILogger<LektorController> _logger;
        private readonly IConfiguration _configuration;
        public LektorController(ILogger<LektorController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet]
        public Lektor GetLektor(int id)
        {
            string greeting = _configuration["Greeting"];
            _logger.LogWarning("Get Lektor");
            return new Lektor() { LektorId = 1, Vorname = "Hans", Nachname = "Grabner" };
        }

        [HttpPost]
        public ActionResult PostLektor(Lektor lektor)
        {
            return CreatedAtAction("GetLektor", new { id = lektor.LektorId }, lektor);
        }
    }
}
