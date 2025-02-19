using Melodex.Application.Interfaces;
using Melodex.Application.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class VinylController : ControllerBase
{
    private readonly IVinylService _vinylService;

    public VinylController(IVinylService vinylService)
    {
        _vinylService = vinylService;
    }

    [HttpGet(Name = "GetVinyls")]
    public async Task<IActionResult> GetVinyls()
    {
        var vinyls = _vinylService.GetAll();
        return Ok(vinyls);
    }
}
