using Microsoft.AspNetCore.Mvc;

namespace path_traversal.Controllers;

[ApiController]
[Route("[controller]")]
public class VulnerableController : ControllerBase
{
	[HttpGet]
	public IActionResult Get(string fileName)
	{
		// path traversal vulnerability
		return PhysicalFile(fileName, "text/plain");
	}
}
