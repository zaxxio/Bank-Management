using Microsoft.AspNetCore.Mvc;

namespace CQRS.Command.Api.Controllers;

/// <summary>
/// Index Controller
/// </summary>
[Route("")]
public class IndexController : ControllerBase
{
    /// <summary>
    /// Print Hello World
    /// </summary>
    // /// <param name="id">Identifier</param>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}