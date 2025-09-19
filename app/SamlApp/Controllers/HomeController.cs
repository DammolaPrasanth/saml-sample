using Microsoft.AspNetCore.Mvc;

namespace SamlApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("health")]
    public IActionResult Health() => Ok(new { status = "healthy", when = System.DateTime.UtcNow });

    [HttpGet("hello")]
    public IActionResult Hello() => Ok(new { message = "Hello from SamlApp" });
}
