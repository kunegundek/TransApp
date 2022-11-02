using Microsoft.AspNetCore.Mvc;

namespace TransApp.ApplicationRoot.Controllers;

[ApiController]
[Route("api/v1")]
public class TruckController : ControllerBase
{
    private readonly ILogger<TruckController> _logger;

    public TruckController(ILogger<TruckController> logger)
    {
        _logger = logger;
    }

    public IActionResult GetTrucks()
    {
        return "Hello world!";
    }
    
}