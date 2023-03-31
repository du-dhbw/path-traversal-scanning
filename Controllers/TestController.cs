using Microsoft.AspNetCore.Mvc;

namespace path_traversal.Controllers;

[ApiController]
[Route("[controller]")]
public class VulnerableController : ControllerBase
{
	[HttpGet]
	public IActionResult Get([FromQuery] string fileName)
	{
		var text = System.IO.File.ReadAllText(fileName);
		return Ok(text);
	}
}
