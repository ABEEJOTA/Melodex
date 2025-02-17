using Melodex.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MediaItemController : ControllerBase
{
    private readonly IMediaItemService _mediaItemService;

    public MediaItemController(IMediaItemService mediaItemService)
    {
        _mediaItemService = mediaItemService;
    }

    [HttpGet(Name = "GetMediaItems")]
    public async Task<IActionResult> GetMediaItems()
    {
        var albums = _mediaItemService.GetAll();
        return Ok(albums);
    }
}
