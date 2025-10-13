using Microsoft.AspNetCore.Mvc;

namespace AppointmentManagement.Api.Controllers;

/// <summary>
/// Authentication Controller
/// </summary>
[Route("[controller]")]
public class AuthenticationController : Controller
{
    /// <summary>
    /// Test
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}