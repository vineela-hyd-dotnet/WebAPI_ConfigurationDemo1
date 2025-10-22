using ConfigurationUsingStronglyTypedDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationUsingStronglyTypedDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigDemo2StronglyTypedController : ControllerBase
    {
        private readonly AppSettings _settings;
        public ConfigDemo2StronglyTypedController(IOptions<AppSettings>options)
        {
            _settings=options.Value;
        }
        [HttpGet]
        public IActionResult GetSettings()
        {
            return Ok(_settings);
        }
    }
}
