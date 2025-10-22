using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_ConfigurationDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigDemoController : ControllerBase
    {
        private readonly IConfiguration _config;
        public ConfigDemoController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public IActionResult GetAppSettings()
        {
            var appName = _config["AppSettings:ApplicationName"];
            var version = _config["AppSettings:Version"];
            return Ok(new {appName,version});
        }

    }
}
