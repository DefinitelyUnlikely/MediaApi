using MediaApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MediaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MediaController(ILogger<MediaController> logger, IMediaService mediaService) : ControllerBase
{
    [HttpGet("/media")]
    public async Task<IActionResult> GetAvailableMediaMeta()
    {
        return new OkObjectResult(await mediaService.GetAllMediaInfoAsync());
    }

    [HttpGet("/media/{path}")]
    public Task<IActionResult> StreamMedia(string path)
    {
        logger.LogInformation("Streaming Media");
        throw new NotImplementedException("");
    }
}
