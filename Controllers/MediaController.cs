using Microsoft.AspNetCore.Mvc;

namespace MediaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MediaController(ILogger<MediaController> logger) : ControllerBase
{
    [HttpGet("/media")]
    public Task<IActionResult> GetAvailableMediaMeta()
    {
        logger.LogInformation("Getting Media Meta info");
        throw new NotImplementedException("");
    }

    [HttpGet("/media/{path}")]
    public Task<IActionResult> StreamMedia(string path)
    {
        logger.LogInformation("Streaming Media");
        throw new NotImplementedException("");
    }
}
